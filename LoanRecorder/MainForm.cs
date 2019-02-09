using LoanRecorder.Common;
using LoanRecorder.Core;
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

        }

        private void addCustBtn_Click(object sender, EventArgs e)
        {
            if (newCustNameTxtBox.Equals(""))
                MessageBox.Show("Name cannot be empty!", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (newCustNicTxtBox.Equals(""))
                MessageBox.Show("NIC cannot be empty!", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (newCustTelTxtBox.Equals(""))
                MessageBox.Show("Telephone number cannot be empty!", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (newCustAddressTxtBox.Equals(""))
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

        private void clearAddCustomer()
        {
            newCustNameTxtBox.Text = "";
            newCustNicTxtBox.Text = "";
            newCustTelTxtBox.Text = "";
            newCustAddressTxtBox.Text = "";
        }

        private void clearUpdateCustomer()
        {
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
    }
}
