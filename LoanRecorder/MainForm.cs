﻿using LoanRecorder.Common;
using LoanRecorder.Core;
using LoanRecorder.Role;
using LoanRecorder.Role.Views;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanRecorder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            fillDuePayDataGrid();
            setLabelValues();

            fillCustomerDataGrid();

            fillCurrentInterestRate();

            fillLoanDataGrid();

            fillCustomerCmbBoxes();
            fillLoanTypeCmbBoxes();

            // setInterestRate();
        }

        private void setLabelValues()
        {

        }

        private void fillDuePayDataGrid()
        {
            DataTable table = new DataTable();

            duePayDataGrid.DataSource = null;

            LinkedList<DuePaymentView> dues = Database.GetDue();

            table.Columns.Add("pid", typeof(long));
            table.Columns.Add("loanId", typeof(long));
            table.Columns.Add("Customer", typeof(string));
            table.Columns.Add("Rel. Amount", typeof(double));
            table.Columns.Add("Term No", typeof(int));
            table.Columns.Add("Amount", typeof(double));
            table.Columns.Add("Due Date", typeof(DateTime));

            foreach (DuePaymentView d in dues)
            {
                DataRow row = table.NewRow();
                
                row[0] = d.Pid;
                row[1] = d.LoanId;
                row[2] = d.Name;
                row[3] = d.RelAmount;
                row[4] = d.TermNo;
                row[5] = d.Amount;
                row[6] = d.DueDate;
                
                table.Rows.Add(row);
            }

            duePayDataGrid.DataSource = table;

            duePayDataGrid.Sort(duePayDataGrid.Columns[6], ListSortDirection.Descending);

            duePayDataGrid.Columns[0].Visible = false;
            duePayDataGrid.Columns[1].Visible = false;
        }

        private void setInterestRate()
        {
            double rate = Database.GetInterestRate();

            if (rate >= 0.00)
            {
                Global.INTEREST = rate;

                rateTxtBox.Text = "" + rate;
            }
        }

        private void fillLoanDataGridUsingList(LinkedList<LoanDataGridView> list)
        {
            DataTable table = new DataTable();

            loanDataGrid.DataSource = null;

            LinkedList<LoanDataGridView> loans = list;

            table.Columns.Add("loan Details Id", typeof(long));
            table.Columns.Add("pid", typeof(long));
            table.Columns.Add("loan Type Id", typeof(int));
            table.Columns.Add("Customer", typeof(string));
            table.Columns.Add("NIC", typeof(string));
            table.Columns.Add("Type", typeof(string));
            table.Columns.Add("Rel. Date", typeof(DateTime));
            table.Columns.Add("Rel. Amount", typeof(double));
            table.Columns.Add("No of Terms", typeof(int));
            table.Columns.Add("Per Term", typeof(double));
            table.Columns.Add("Paid Terms", typeof(int));
            table.Columns.Add("Paid Amount", typeof(double));
            table.Columns.Add("To Pay", typeof(double));
            table.Columns.Add("Profit", typeof(double));

            foreach (LoanDataGridView loan in loans)
            {
                DataRow row = table.NewRow();

                row[0] = loan.LoanDetailsId;
                row[1] = loan.Pid;
                row[2] = loan.LoanTypeId;
                row[3] = loan.Name;
                row[4] = loan.Nic;
                row[5] = loan.LoanTypeName;
                row[6] = loan.RelDate;
                row[7] = loan.RelAmount;
                row[8] = loan.NoOfTerms;
                row[9] = loan.AmountPerTerm;
                row[10] = loan.PaidCount;
                row[11] = loan.PaidAmount;
                row[12] = (loan.Profit + loan.RelAmount) - loan.PaidAmount;
                row[13] = loan.Profit;

                table.Rows.Add(row);
            }
            
            loanDataGrid.DataSource = table;

            loanDataGrid.Columns[0].Visible = false;
            loanDataGrid.Columns[1].Visible = false;
            loanDataGrid.Columns[2].Visible = false;
        }

        private void fillLoanDataGrid()
        {
            DataTable table = new DataTable();

            loanDataGrid.DataSource = null;

            LinkedList<LoanDataGridView> loans = Database.GetAllLoanDetails();

            table.Columns.Add("loan Details Id", typeof(long));
            table.Columns.Add("pid", typeof(long));
            table.Columns.Add("loan Type Id", typeof(int));
            table.Columns.Add("Customer", typeof(string));
            table.Columns.Add("NIC", typeof(string));
            table.Columns.Add("Type", typeof(string));
            table.Columns.Add("Rel. Date", typeof(DateTime));
            table.Columns.Add("Rel. Amount", typeof(double));
            table.Columns.Add("No of Terms", typeof(int));
            table.Columns.Add("Per Term", typeof(double));
            table.Columns.Add("Paid Terms", typeof(int));
            table.Columns.Add("Paid Amount", typeof(double));
            table.Columns.Add("To Pay", typeof(double));
            table.Columns.Add("Profit", typeof(double));

            foreach (LoanDataGridView loan in loans)
            {
                DataRow row = table.NewRow();
                
                row[0] = loan.LoanDetailsId;
                row[1] = loan.Pid;
                row[2] = loan.LoanTypeId;
                row[3] = loan.Name;
                row[4] = loan.Nic;
                row[5] = loan.LoanTypeName;
                row[6] = loan.RelDate;
                row[7] = loan.RelAmount;
                row[8] = loan.NoOfTerms;
                row[9] = loan.AmountPerTerm;
                row[10] = loan.PaidCount;
                row[11] = Math.Round(loan.PaidAmount);
                
                if (loan.NoOfTerms == loan.PaidCount)
                    row[12] = 0;
                else
                    row[12] = (loan.Profit + loan.RelAmount) - loan.PaidAmount;

                row[13] = loan.Profit;
                
                table.Rows.Add(row);
            }

            // var list = new BindingList<LoanDetails>(loans.ToList());

            loanDataGrid.DataSource = table;

            loanDataGrid.Columns[0].Visible = false;
            loanDataGrid.Columns[1].Visible = false;
            loanDataGrid.Columns[2].Visible = false;

            totLoanLabel.Text = "" + loans.Count;
            totProfitLabel.Text = "" + table.Compute("SUM(Profit)", string.Empty).ToString();
        }

        private void fillLoanTypeCmbBoxes()
        {
            LinkedList<LoanType> types = Database.GetAllLoanTypes();

            DataTable table = new DataTable();

            table.Columns.Add("id");
            table.Columns.Add("name");

            foreach (LoanType type in types)
            {
                DataRow row = table.NewRow();

                row["id"] = type.Id;
                row["name"] = type.Type_name;

                table.Rows.Add(row);
            }

            issueLoanTypeCmbBox.DataSource = table;

            issueLoanTypeCmbBox.ValueMember = "id";
            issueLoanTypeCmbBox.DisplayMember = "name";
        }

        private void fillCustomerCmbBoxes()
        {
            LinkedList<Person> persons = Database.GetAllPersons();

            DataTable table = new DataTable();

            table.Columns.Add("pid");
            table.Columns.Add("name");

            foreach (Person person in persons)
            {
                DataRow row = table.NewRow();

                row["pid"] = person.Pid;
                row["name"] = person.Name;

                table.Rows.Add(row);
            }

            issueLoanCustCmbBox.DataSource = table;

            issueLoanCustCmbBox.ValueMember = "pid";
            issueLoanCustCmbBox.DisplayMember = "name";
        }

        private void fillCurrentInterestRate()
        {
            double rate = Database.GetInterestRate();

            curRateTxtBox.Text = "" + rate;

            setInterestRate();
        }

        private void fillCustomerDataGrid()
        {
            customerDataGrid.DataSource = null;

            LinkedList<Person> customers = Database.GetAllPersons();

            var list = new BindingList<Person>(customers.ToList());

            customerDataGrid.DataSource = list;

            customerDataGrid.Columns[0].Visible = false;

            totCustLabel.Text = "" + customers.Count;
        }

        private void fillCustomerDataGridUsingList(LinkedList<Person> customers)
        {
            var list = new BindingList<Person>(customers.ToList());

            customerDataGrid.DataSource = list;

            customerDataGrid.Columns[0].Visible = false;
        }

        private void addCustBtn_Click(object sender, EventArgs e)
        {
            if (newCustNameTxtBox.Text.Equals(""))
                MessageBox.Show("Name cannot be empty!", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (newCustNicTxtBox.Text.Equals(""))
                MessageBox.Show("NIC cannot be empty!", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (newCustTelTxtBox.Text.Equals(""))
                MessageBox.Show("Telephone number cannot be empty!", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (newCustAddressTxtBox.Text.Equals(""))
                MessageBox.Show("Address cannot be empty!", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string name = newCustNameTxtBox.Text;
                string nic = newCustNicTxtBox.Text;
                string tel = newCustTelTxtBox.Text;
                string address = newCustAddressTxtBox.Text;

                if (Database.GetPersonByNic(nic) == null)
                {
                    if (Database.GetPersonByTel(tel) == null)
                    {
                        if (Database.AddPerson(new Role.Person(name, nic, tel, address)))
                        {
                            clearAddCustomer();
                            fillCustomerDataGrid();

                            notifyIcon.Icon = SystemIcons.Application;
                            notifyIcon.BalloonTipText = "Customer Successfully added!";
                            notifyIcon.ShowBalloonTip(200);

                            fillCustomerCmbBoxes();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Telephone number already exists!", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("NIC already exists!", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void updateCustBtn_Click(object sender, EventArgs e)
        {
            if (updateCustNameTxtBox.Text.Equals(""))
                MessageBox.Show("Name cannot be empty!", "Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (updateCustNicTxtBox.Text.Equals(""))
                MessageBox.Show("NIC cannot be empty!", "Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (updateCustTelTxtBox.Text.Equals(""))
                MessageBox.Show("Telephone number cannot be empty!", "Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (updateCustAddressTxtBox.Text.Equals(""))
                MessageBox.Show("Address cannot be empty!", "Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                long pid;

                if (!long.TryParse(updateCustIdTxtBox.Text, out pid))
                    MessageBox.Show("You haven't selected a customer!", "Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else
                {
                    string name = updateCustNameTxtBox.Text;
                    string nic = updateCustNicTxtBox.Text;
                    string tel = updateCustTelTxtBox.Text;
                    string address = updateCustAddressTxtBox.Text;

                    Person personByNic = Database.GetPersonByNic(nic);
                    Person personByTel = Database.GetPersonByTel(tel);

                    if ((personByNic != null) && (personByNic.Pid != pid))
                    {
                        MessageBox.Show("NIC already exists!", "Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if ((personByTel != null) && (personByTel.Pid != pid))
                        {
                            MessageBox.Show("Telephone number already exists!", "Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (Database.UpdatePerson(new Role.Person(pid, name, nic, tel, address)))
                            {
                                clearUpdateCustomer();
                                fillCustomerDataGrid();

                                notifyIcon.Icon = SystemIcons.Application;
                                notifyIcon.BalloonTipText = "Customer Successfully updated!";
                                notifyIcon.ShowBalloonTip(200);

                                fillCustomerCmbBoxes();
                            }
                        }
                    }
                }
            }
        }

        private void customerDataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (dgv.CurrentRow.Selected)
            {
                long pid = Int32.Parse(customerDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                string name = customerDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                string nic = customerDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                string tel = customerDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                string address = customerDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();

                fillUpdateCustomerPanel(pid, name, nic, tel, address);
            }
        }

        private void customerDataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Add delete function if requested.
        }

        private void fillUpdateCustomerPanel(long pid, string name, string nic, string tel, string address)
        {
            updateCustIdTxtBox.Text = "" + pid;
            updateCustNameTxtBox.Text = name;
            updateCustNicTxtBox.Text = nic;
            updateCustTelTxtBox.Text = tel;
            updateCustAddressTxtBox.Text = address;
        }

        private void clearAddCustomer()
        {
            newCustNameTxtBox.Text = "";
            newCustNicTxtBox.Text = "";
            newCustTelTxtBox.Text = "";
            newCustAddressTxtBox.Text = "";
        }

        private void clearUpdateCustomer()
        {
            updateCustIdTxtBox.Text = "A";
            updateCustNameTxtBox.Text = "";
            updateCustNicTxtBox.Text = "";
            updateCustTelTxtBox.Text = "";
            updateCustAddressTxtBox.Text = "";
        }

        private void clearIssueLoanPanel()
        {
            issueLoanCustNicTxtBox.Text = "";
            issueLoanCustCmbBox.SelectedIndex = 0;
            issueLoanRelDatePicker.Value = DateTime.Now;
            issueLoanAmountTxtBox.Text = "";
            issueLoanTypeCmbBox.SelectedIndex = 0;

            issueLoanNoOfTermsTxtBox.Text = "";
            issueLoanTermPaymentTxtBox.Text = "";

            issueLoanPayableTxtBox.Text = "";
            issueLoanProfitTxtBox.Text = "";

            issueLoanGuarName1TxtBox.Text = "";
            issueLoanGuarName2TxtBox.Text = "";
            issueLoanGuarAddress1TxtBox.Text = "";
            issueLoanGuarAddress2TxtBox.Text = "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Connection.backupDB();
        }

        private void newCustNameTxtBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;

            if (!Validation.isLettersOnly(newCustNameTxtBox.Text))
            {
                e.Cancel = true;

                errorMsg = "Invalid Name!";

                newCustNameTxtBox.Select(0, newCustNameTxtBox.Text.Length);

                this.mainFormErrorProvider.SetError(newCustNameTxtBox, errorMsg);
            }
        }

        private void newCustNameTxtBox_Validated(object sender, EventArgs e)
        {
            mainFormErrorProvider.SetError(newCustNameTxtBox, "");
            mainFormErrorProvider.Clear();
        }

        private void newCustNicTxtBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;

            if (!Validation.isNic(newCustNicTxtBox.Text))
            {
                e.Cancel = true;

                errorMsg = "Invalid NIC!";

                newCustNicTxtBox.Select(0, newCustNicTxtBox.Text.Length);

                this.mainFormErrorProvider.SetError(newCustNicTxtBox, errorMsg);
            }
        }

        private void newCustNicTxtBox_Validated(object sender, EventArgs e)
        {
            mainFormErrorProvider.SetError(newCustNicTxtBox, "");
            mainFormErrorProvider.Clear();
        }

        private void newCustTelTxtBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;

            if (!Validation.isPhoneNumber(newCustTelTxtBox.Text))
            {
                e.Cancel = true;

                errorMsg = "Invalid NIC!";

                newCustTelTxtBox.Select(0, newCustTelTxtBox.Text.Length);

                this.mainFormErrorProvider.SetError(newCustTelTxtBox, errorMsg);
            }
        }

        private void newCustTelTxtBox_Validated(object sender, EventArgs e)
        {
            mainFormErrorProvider.SetError(newCustTelTxtBox, "");
            mainFormErrorProvider.Clear();
        }

        private void addCustClearBtn_Click(object sender, EventArgs e)
        {
            clearAddCustomer();
        }

        private void updateCustClearBtn_Click(object sender, EventArgs e)
        {
            clearUpdateCustomer();
        }

        private void updateCustNameTxtBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;

            if (!Validation.isLettersOnly(updateCustNameTxtBox.Text))
            {
                e.Cancel = true;

                errorMsg = "Invalid Name!";

                updateCustNameTxtBox.Select(0, updateCustNameTxtBox.Text.Length);

                this.mainFormErrorProvider.SetError(updateCustNameTxtBox, errorMsg);
            }
        }

        private void updateCustNameTxtBox_Validated(object sender, EventArgs e)
        {
            mainFormErrorProvider.SetError(updateCustNameTxtBox, "");
            mainFormErrorProvider.Clear();
        }

        private void updateCustNicTxtBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;

            if (!Validation.isNic(updateCustNicTxtBox.Text))
            {
                e.Cancel = true;

                errorMsg = "Invalid NIC!";

                updateCustNicTxtBox.Select(0, updateCustNicTxtBox.Text.Length);

                this.mainFormErrorProvider.SetError(updateCustNicTxtBox, errorMsg);
            }
        }

        private void updateCustNicTxtBox_Validated(object sender, EventArgs e)
        {
            mainFormErrorProvider.SetError(updateCustNicTxtBox, "");
            mainFormErrorProvider.Clear();
        }

        private void updateCustTelTxtBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;

            if (!Validation.isPhoneNumber(updateCustTelTxtBox.Text))
            {
                e.Cancel = true;

                errorMsg = "Invalid NIC!";

                updateCustTelTxtBox.Select(0, updateCustTelTxtBox.Text.Length);

                this.mainFormErrorProvider.SetError(updateCustTelTxtBox, errorMsg);
            }
        }

        private void updateCustTelTxtBox_Validated(object sender, EventArgs e)
        {
            mainFormErrorProvider.SetError(updateCustTelTxtBox, "");
            mainFormErrorProvider.Clear();
        }

        private void searchCustomerByNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            string name = searchCustomerByNameTxtBox.Text;

            if (name.Equals(""))
                fillCustomerDataGrid();
            else
                fillCustomerDataGridUsingList(Database.GetPersonsByName(name));
        }

        private void showAllBtnCustMan_Click(object sender, EventArgs e)
        {
            searchCustomerByNameTxtBox.Text = "";
            fillCustomerDataGrid();
        }

        private void addNewLoanTypeBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently unavailable!", "Add Loan Type", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //if (newLoanTypeTxtBox.Text.Equals(""))
            //    MessageBox.Show("Type Name cannot be empty!", "Add Loan Type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //else
            //{
            //    string typeName = newLoanTypeTxtBox.Text;

            //    if (Database.GetLoanTypeByName(typeName) == null)
            //    {
            //        if (Database.AddLoanType(new LoanType(typeName)))
            //        {
            //            newLoanTypeTxtBox.Text = "";

            //            notifyIcon.Icon = SystemIcons.Application;
            //            notifyIcon.BalloonTipText = "Loan Type Successfully added!";
            //            notifyIcon.ShowBalloonTip(200);

            //            fillLoanTypeCmbBoxes();
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Loan type name already exists!", "Add Loan Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }

        private void changeRateBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature has been disabled!", "Change Rate", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //if (newRateTxtBox.Text.Equals(""))
            //    MessageBox.Show("Rate cannot be empty!", "Change Rate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //else
            //{
            //    string rate = newRateTxtBox.Text;

            //    if (Database.ChangeRate(Double.Parse(rate)))
            //    {
            //        newRateTxtBox.Text = "";
            //        fillCurrentInterestRate();

            //        notifyIcon.Icon = SystemIcons.Application;
            //        notifyIcon.BalloonTipText = "Interest Rate Successfully changed!";
            //        notifyIcon.ShowBalloonTip(200);
            //    }
            //}
        }

        private void newRateTxtBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;

            if (!Validation.isRate(newRateTxtBox.Text))
            {
                e.Cancel = true;

                errorMsg = "Invalid Rate!";

                newRateTxtBox.Select(0, newRateTxtBox.Text.Length);

                this.mainFormErrorProvider.SetError(newRateTxtBox, errorMsg);
            }
        }

        private void newRateTxtBox_Validated(object sender, EventArgs e)
        {
            mainFormErrorProvider.SetError(newRateTxtBox, "");
            mainFormErrorProvider.Clear();
        }

        private void issueLoanBtn_Click(object sender, EventArgs e)
        {
            Object custObj = issueLoanCustCmbBox.SelectedItem;
            Object loanTypeObj = issueLoanTypeCmbBox.SelectedItem;
            DateTime dt = issueLoanRelDatePicker.Value;

            if (custObj == null)
                MessageBox.Show("Select a Customer!", "Issue Loan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (loanTypeObj == null)
                MessageBox.Show("Select a Loan Type!", "Issue Loan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Validation.isFuture(dt))
                MessageBox.Show("Select a valid date!", "Issue Loan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (issueLoanAmountTxtBox.Text.Equals(""))
                MessageBox.Show("Loan Amount cannot be empty!", "Issue Loan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (issueLoanNoOfTermsTxtBox.Text.Equals(""))
                MessageBox.Show("No of terms cannot be empty!", "Issue Loan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (issueLoanTermPaymentTxtBox.Text.Equals(""))
                MessageBox.Show("Loan Term amount cannot be empty!", "Issue Loan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                long pid = Int32.Parse(issueLoanCustCmbBox.SelectedValue.ToString());
                int typeId = Int32.Parse(issueLoanTypeCmbBox.SelectedValue.ToString());
                DateTime relDate = issueLoanRelDatePicker.Value;
                double amount = Double.Parse(issueLoanAmountTxtBox.Text);
                int noOfTerms = Int32.Parse(issueLoanNoOfTermsTxtBox.Text);
                double termPayment = Double.Parse(issueLoanTermPaymentTxtBox.Text);
                double profit = Double.Parse(issueLoanProfitTxtBox.Text);
                string guar1Name = issueLoanGuarName1TxtBox.Text;
                string guar2Name = issueLoanGuarName2TxtBox.Text;
                string guar1Add = issueLoanGuarAddress1TxtBox.Text;
                string guar2Add = issueLoanGuarAddress2TxtBox.Text;

                LinkedList<Guarantor> guarantors = new LinkedList<Guarantor>();

                guarantors.AddLast(new Guarantor(guar1Name, guar1Add));
                guarantors.AddLast(new Guarantor(guar2Name, guar2Add));

                if (Database.IssueLoan(new LoanDetails(relDate, amount, profit, noOfTerms, termPayment, new LoanType(typeId)), guarantors, pid))
                {
                    clearIssueLoanPanel();
                    fillLoanDataGrid();
                    fillDuePayDataGrid();

                    notifyIcon.Icon = SystemIcons.Application;
                    notifyIcon.BalloonTipText = "Loan Successfully issued!";
                    notifyIcon.ShowBalloonTip(200);
                }
            }
        }

        private void clearIssueLoanBtn_Click(object sender, EventArgs e)
        {
            clearIssueLoanPanel();
        }

        private void issueLoanRelDatePicker_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;

            if (Validation.isFuture(issueLoanRelDatePicker.Value))
            {
                e.Cancel = true;

                errorMsg = "Date cannot be in the future!";

                this.mainFormErrorProvider.SetError(issueLoanRelDatePicker, errorMsg);
            }
        }

        private void issueLoanRelDatePicker_Validated(object sender, EventArgs e)
        {
            mainFormErrorProvider.SetError(issueLoanRelDatePicker, "");
            mainFormErrorProvider.Clear();
        }

        private void issueLoanAmountTxtBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;

            if (!Validation.isDouble(issueLoanAmountTxtBox.Text))
            {
                e.Cancel = true;

                errorMsg = "Invalid Amount!";

                issueLoanAmountTxtBox.Select(0, issueLoanAmountTxtBox.Text.Length);

                this.mainFormErrorProvider.SetError(issueLoanAmountTxtBox, errorMsg);
            }
        }

        private void issueLoanAmountTxtBox_Validated(object sender, EventArgs e)
        {
            mainFormErrorProvider.SetError(issueLoanAmountTxtBox, "");
            mainFormErrorProvider.Clear();
        }

        private void issueLoanNoOfTermsTxtBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;

            if (!Validation.isInteger(issueLoanNoOfTermsTxtBox.Text))
            {
                e.Cancel = true;

                errorMsg = "Invalid No of terms!";

                issueLoanNoOfTermsTxtBox.Select(0, issueLoanNoOfTermsTxtBox.Text.Length);

                this.mainFormErrorProvider.SetError(issueLoanNoOfTermsTxtBox, errorMsg);
            }
        }

        private void issueLoanNoOfTermsTxtBox_Validated(object sender, EventArgs e)
        {
            mainFormErrorProvider.SetError(issueLoanNoOfTermsTxtBox, "");
            mainFormErrorProvider.Clear();
        }

        private void issueLoanTermPaymentTxtBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;

            if (!Validation.isDouble(issueLoanTermPaymentTxtBox.Text))
            {
                e.Cancel = true;

                errorMsg = "Invalid Amount!";

                issueLoanTermPaymentTxtBox.Select(0, issueLoanTermPaymentTxtBox.Text.Length);

                this.mainFormErrorProvider.SetError(issueLoanTermPaymentTxtBox, errorMsg);
            }
        }

        private void issueLoanTermPaymentTxtBox_Validated(object sender, EventArgs e)
        {
            mainFormErrorProvider.SetError(issueLoanTermPaymentTxtBox, "");
            mainFormErrorProvider.Clear();
        }

        private void issueLoanGuarName1TxtBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;

            if (!Validation.isLettersOnly(issueLoanGuarName1TxtBox.Text))
            {
                e.Cancel = true;

                errorMsg = "Invalid Name!";

                issueLoanGuarName1TxtBox.Select(0, issueLoanGuarName1TxtBox.Text.Length);

                this.mainFormErrorProvider.SetError(issueLoanGuarName1TxtBox, errorMsg);
            }
        }

        private void issueLoanGuarName1TxtBox_Validated(object sender, EventArgs e)
        {
            mainFormErrorProvider.SetError(issueLoanGuarName1TxtBox, "");
            mainFormErrorProvider.Clear();
        }

        private void issueLoanGuarName2TxtBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;

            if (!Validation.isLettersOnly(issueLoanGuarName2TxtBox.Text))
            {
                e.Cancel = true;

                errorMsg = "Invalid Name!";

                issueLoanGuarName2TxtBox.Select(0, issueLoanGuarName2TxtBox.Text.Length);

                this.mainFormErrorProvider.SetError(issueLoanGuarName2TxtBox, errorMsg);
            }
        }

        private void issueLoanGuarName2TxtBox_Validated(object sender, EventArgs e)
        {
            mainFormErrorProvider.SetError(issueLoanGuarName2TxtBox, "");
            mainFormErrorProvider.Clear();
        }

        private void issueLoanCustCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (issueLoanCustCmbBox.SelectedItem != null)
            {
                long custId;

                if (long.TryParse(issueLoanCustCmbBox.SelectedValue.ToString(), out custId))
                {
                    Person person = Database.GetPersonById(Int32.Parse(issueLoanCustCmbBox.SelectedValue.ToString()));

                    if (person != null)
                    {
                        issueLoanCustNicTxtBox.Text = person.Nic;
                    }
                }
            }
        }

        private void issueLoanAmountTxtBox_TextChanged(object sender, EventArgs e)
        {
            double amount = 0.0;

            if (double.TryParse(issueLoanAmountTxtBox.Text, out amount))
            {
                issueLoanPayableTxtBox.Text = "" + (amount + Global.FULL_PROFIT(amount));
                issueLoanProfitTxtBox.Text = "" + Global.FULL_PROFIT(amount);

                setNoOfTerms();
            }
            else
            {
                issueLoanPayableTxtBox.Text = "";
                issueLoanProfitTxtBox.Text = "";
            }
        }
        
        private void searchLoanByCustTxtBox_TextChanged(object sender, EventArgs e)
        {
            string name = searchLoanByCustTxtBox.Text;

            if (name.Equals(""))
                fillLoanDataGrid();
            else
                fillLoanDataGridUsingList(Database.GetAllLoanDetailsByCutomerName(name));
        }

        private void loanShowAllBtn_Click(object sender, EventArgs e)
        {
            searchLoanByCustTxtBox.Text = "";

            fillLoanDataGrid();
        }

        private void loanDataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (dgv.CurrentRow.Selected)
            {
                double toPay = double.Parse(loanDataGrid.Rows[e.RowIndex].Cells[12].Value.ToString());

                if (toPay <= 0.0)
                {
                    MessageBox.Show("This loan is settled!", "Term Payment", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    long loanId = Int32.Parse(loanDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                    long pid = Int32.Parse(loanDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString());
                    string name = loanDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                    string nic = loanDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                    int termNo = Int32.Parse(loanDataGrid.Rows[e.RowIndex].Cells[10].Value.ToString()) + 1;
                    int noOfTerms = Int32.Parse(loanDataGrid.Rows[e.RowIndex].Cells[8].Value.ToString());
                    double amountPerTerm = double.Parse(loanDataGrid.Rows[e.RowIndex].Cells[9].Value.ToString());
                    double paidAmount = double.Parse(loanDataGrid.Rows[e.RowIndex].Cells[11].Value.ToString());
                    double relAmount = double.Parse(loanDataGrid.Rows[e.RowIndex].Cells[7].Value.ToString());
                    string type = loanDataGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
                    DateTime relDate = DateTime.Parse(loanDataGrid.Rows[e.RowIndex].Cells[6].Value.ToString());
                    
                    AddPaymentForm frm = new AddPaymentForm(new Person(pid, name, nic), loanId, termNo, amountPerTerm, toPay, relDate, noOfTerms, relAmount, paidAmount);

                    frm.ShowDialog();
                    
                    fillLoanDataGrid();
                    fillDuePayDataGrid();
                }
            }
        }
        
        private void showMoreBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow cr = loanDataGrid.CurrentRow;

            double paidAmount = double.Parse(cr.Cells[11].Value.ToString());

            if (paidAmount <= 0.0)
            {
                MessageBox.Show("This loan has no payments!", "Show Payment Details", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                long pid = Int32.Parse(cr.Cells[1].Value.ToString());
                long loanId = Int32.Parse(cr.Cells[0].Value.ToString());
                string name = cr.Cells[3].Value.ToString();
                string nic = cr.Cells[4].Value.ToString();
                DateTime relDate = DateTime.Parse(cr.Cells[6].Value.ToString());
                double relAmount = double.Parse(cr.Cells[7].Value.ToString());
                double toPay = double.Parse(cr.Cells[12].Value.ToString());
                double profit = double.Parse(cr.Cells[13].Value.ToString());

                PaymentDetailsForm frm = new PaymentDetailsForm(pid, loanId, name, nic, relDate, relAmount, paidAmount, toPay, profit);

                frm.ShowDialog();
            }
        }

        private void setAmountPerTerm()
        {
            int noOfTerms = 0;
            double amount = 0.0;

            if (double.TryParse(issueLoanAmountTxtBox.Text, out amount))
            {
                if (int.TryParse(issueLoanNoOfTermsTxtBox.Text, out noOfTerms))
                {
                    double total = Global.FULL_PROFIT(amount) + amount;
                    double amountPerTerm = total / noOfTerms;

                    issueLoanTermPaymentTxtBox.Text = "" + amountPerTerm;
                }
                else
                {
                    issueLoanTermPaymentTxtBox.Text = "";
                }
            }
        }

        private void setNoOfTerms()
        {
            Object obj = issueLoanTypeCmbBox.SelectedItem;

            if (obj != null)
            {
                string type = issueLoanTypeCmbBox.GetItemText(obj);

                switch (type)
                {
                    case "Daily":
                        issueLoanNoOfTermsTxtBox.Text = "" + Global.D_LOAN_PERIOD_DAYS;
                        break;
                    case "Weekly":
                        issueLoanNoOfTermsTxtBox.Text = "" + Global.W_LOAN_PERIOD_DAYS;
                        break;
                    case "FiveDay":
                        issueLoanNoOfTermsTxtBox.Text = "" + Global.F_LOAN_PERIOD_DAYS;
                        break;
                }

                setAmountPerTerm();
            }
        }

        private void issueLoanTypeCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            setNoOfTerms();
        }
    }
}
