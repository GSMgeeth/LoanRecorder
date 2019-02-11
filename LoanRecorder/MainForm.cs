using LoanRecorder.Common;
using LoanRecorder.Core;
using LoanRecorder.Role;
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
            fillCustomerDataGrid();

            fillCurrentInterestRate();

            fillLoanDataGrid();

            fillCustomerCmbBoxes();
            fillLoanTypeCmbBoxes();
        }

        private void fillLoanDataGrid()
        {
            DataTable table = new DataTable();

            loanDataGrid.DataSource = null;

            LinkedList<LoanDetails> loans = Database.GetAllLoans();

            foreach (LoanDetails loan in loans)
            {
                // add these to table //

                // get customer name and id and nic
                // calculate profit
                // how many terms to go
                // total paid amount
                // to pay amount
                // to pay terms
            }

            var list = new BindingList<LoanDetails>(loans.ToList());

            loanDataGrid.DataSource = list;

            // loanDataGrid.Columns[0].Visible = false;
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
        }

        private void fillCustomerDataGrid()
        {
            customerDataGrid.DataSource = null;

            LinkedList<Person> customers = Database.GetAllPersons();

            var list = new BindingList<Person>(customers.ToList());

            customerDataGrid.DataSource = list;

            customerDataGrid.Columns[0].Visible = false;
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
            if (newLoanTypeTxtBox.Text.Equals(""))
                MessageBox.Show("Type Name cannot be empty!", "Add Loan Type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string typeName = newLoanTypeTxtBox.Text;

                if (Database.GetLoanTypeByName(typeName) == null)
                {
                    if (Database.AddLoanType(new LoanType(typeName)))
                    {
                        newLoanTypeTxtBox.Text = "";

                        notifyIcon.Icon = SystemIcons.Application;
                        notifyIcon.BalloonTipText = "Loan Type Successfully added!";
                        notifyIcon.ShowBalloonTip(200);

                        fillLoanTypeCmbBoxes();
                    }
                }
                else
                {
                    MessageBox.Show("Loan type name already exists!", "Add Loan Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void changeRateBtn_Click(object sender, EventArgs e)
        {
            if (newRateTxtBox.Text.Equals(""))
                MessageBox.Show("Rate cannot be empty!", "Change Rate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string rate = newRateTxtBox.Text;

                if (Database.ChangeRate(Double.Parse(rate)))
                {
                    newRateTxtBox.Text = "";
                    fillCurrentInterestRate();

                    notifyIcon.Icon = SystemIcons.Application;
                    notifyIcon.BalloonTipText = "Interest Rate Successfully changed!";
                    notifyIcon.ShowBalloonTip(200);
                }
            }
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
                string guar1Name = issueLoanGuarName1TxtBox.Text;
                string guar2Name = issueLoanGuarName2TxtBox.Text;
                string guar1Add = issueLoanGuarAddress1TxtBox.Text;
                string guar2Add = issueLoanGuarAddress2TxtBox.Text;

                LinkedList<Guarantor> guarantors = new LinkedList<Guarantor>();

                guarantors.AddLast(new Guarantor(guar1Name, guar1Add));
                guarantors.AddLast(new Guarantor(guar2Name, guar2Add));

                if (Database.IssueLoan(new LoanDetails(relDate, amount, noOfTerms, termPayment, new LoanType(typeId)), guarantors, pid))
                {
                    clearIssueLoanPanel();
                    fillLoanDataGrid();

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
    }
}
