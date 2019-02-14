using LoanRecorder.Common;
using LoanRecorder.Core;
using LoanRecorder.Role;
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
    public partial class AddPaymentForm : Form
    {
        private Person person;
        private int termNo;
        private double amount;
        private long loanId;

        public AddPaymentForm()
        {
            InitializeComponent();
        }

        public AddPaymentForm(Person person, long loanId, int termNo, double amount)
        {
            InitializeComponent();

            this.person = person;
            this.termNo = termNo;
            this.loanId = loanId;
            this.amount = amount;
        }

        private void AddPaymentForm_Load(object sender, EventArgs e)
        {
            addPayCustNameTxtBox.Text = person.Name;
            addPayCustNicTxtBox.Text = person.Nic;
            addPayAmountTxtBox.Text = "" + amount;
            addPayTermNoTxtBox.Text = "" + termNo;
        }
        
        private void addPayDatePicker_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;

            if (Validation.isFuture(addPayDatePicker.Value))
            {
                e.Cancel = true;

                errorMsg = "Invalid Date!";
                
                this.addPaymentErrorProvider.SetError(addPayDatePicker, errorMsg);
            }
        }

        private void addPayDatePicker_Validated(object sender, EventArgs e)
        {
            addPaymentErrorProvider.SetError(addPayDatePicker, "");
            addPaymentErrorProvider.Clear();
        }

        private void addPayBtn_Click(object sender, EventArgs e)
        {
            if (!Validation.isFuture(addPayDatePicker.Value))
            {
                if (Database.AddPayment(person.Pid, loanId, termNo, amount, addPayDatePicker.Value))
                {
                    notifyIcon.Icon = SystemIcons.Application;
                    notifyIcon.BalloonTipText = "Payment Successfully added!";
                    notifyIcon.ShowBalloonTip(200);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Something went wrong!\nPlease check your database connection.", "Add Payment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select the paid date!", "Add Payment", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
