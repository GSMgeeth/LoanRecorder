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
    }
}
