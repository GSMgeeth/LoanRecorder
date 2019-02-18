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
        private double amountPerTerm;
        private long loanId;
        private double toPay;
        private DateTime relDate;
        private int terms;
        private double relAmount;
        private double paidAmount;

        public AddPaymentForm()
        {
            InitializeComponent();
        }

        public AddPaymentForm(Person person, long loanId, int termNo, double amountPerTerm, double toPay, DateTime relDate, int terms, double relAmount, double paidAmount)
        {
            InitializeComponent();

            this.person = person;
            this.termNo = termNo;
            this.loanId = loanId;
            this.amountPerTerm = amountPerTerm;
            this.toPay = toPay;
            this.relDate = relDate;
            this.terms = terms;
            this.relAmount = relAmount;
            this.paidAmount = paidAmount;
        }

        private void AddPaymentForm_Load(object sender, EventArgs e)
        {
            addPayToTermTxtBox.Minimum = termNo;
            addPayToTermTxtBox.Maximum = terms;
            addPayCustNameTxtBox.Text = person.Name;
            addPayCustNicTxtBox.Text = person.Nic;
            addPayAmountTxtBox.Text = "" + amountPerTerm;
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
                int toTerm = (int)addPayToTermTxtBox.Value;

                if (toTerm > termNo)
                {
                    double payingAmount = double.Parse(addPayAmountTxtBox.Text);

                    if ((toTerm == terms) && isEarlyDone())
                    {
                        toPay = (Global.HALF_PROFIT(relAmount) + relAmount) - paidAmount;
                        amountPerTerm = (int)(toPay / ((toTerm - termNo) + 1));
                    }

                    if (Database.AddPayments(person.Pid, loanId, termNo, toTerm, amountPerTerm, addPayDatePicker.Value))
                    {
                        notifyIcon.Icon = SystemIcons.Application;
                        notifyIcon.BalloonTipText = "Payments Successfully added!";
                        notifyIcon.ShowBalloonTip(200);
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong!\nPlease check your database connection.", "Add Payment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (Database.AddPayment(person.Pid, loanId, termNo, amountPerTerm, addPayDatePicker.Value))
                    {
                        notifyIcon.Icon = SystemIcons.Application;
                        notifyIcon.BalloonTipText = "Payment Successfully added!";
                        notifyIcon.ShowBalloonTip(200);
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong!\nPlease check your database connection.", "Add Payment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                SettleLoan();

                this.Close();
            }
            else
            {
                MessageBox.Show("Please select the paid date!", "Add Payment", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean isEarlyDone()
        {
            double days = (addPayDatePicker.Value - relDate).TotalDays;

            return (days <= 30);
        }

        private void SettleLoan()
        {
            int toTerm = Int32.Parse(addPayToTermTxtBox.Text);

            if (toTerm == terms)
            {
                Database.SettleLoan(loanId);
                
                if (isEarlyDone())
                {
                    Database.MakeProfitHalf(loanId);
                }
            }
        }

        private void addPayToTermTxtBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;

            if ((Int32.Parse(addPayToTermTxtBox.Text) > addPayToTermTxtBox.Maximum) || (Int32.Parse(addPayToTermTxtBox.Text) < addPayToTermTxtBox.Minimum))
            {
                e.Cancel = true;

                errorMsg = "Invalid To Term!";

                this.addPaymentErrorProvider.SetError(addPayToTermTxtBox, errorMsg);
            }
        }

        private void addPayToTermTxtBox_Validated(object sender, EventArgs e)
        {
            addPaymentErrorProvider.SetError(addPayToTermTxtBox, "");
            addPaymentErrorProvider.Clear();

        }

        private void addPayToTermTxtBox_ValueChanged(object sender, EventArgs e)
        {
            if (!Validation.isFuture(addPayDatePicker.Value))
            {
                int toTerm = Int32.Parse(addPayToTermTxtBox.Value.ToString());

                Console.WriteLine("cal toTerm : " + toTerm);
                Console.WriteLine("cal terms : " + terms);
                Console.WriteLine("cal termNo : " + termNo + "\n");

                if ((toTerm == terms) && isEarlyDone())
                {
                    addPayAmountTxtBox.Text = "" + ((Global.HALF_PROFIT(relAmount) + relAmount) - paidAmount);
                }
                else
                {
                    addPayAmountTxtBox.Text = "" + amountPerTerm * ((toTerm - termNo) + 1);
                }
            }
        }

        private void addPayDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (!Validation.isFuture(addPayDatePicker.Value))
            {
                int toTerm = Int32.Parse(addPayToTermTxtBox.Value.ToString());

                Console.WriteLine("cal toTerm : " + toTerm);
                Console.WriteLine("cal terms : " + terms);
                Console.WriteLine("cal termNo : " + termNo + "\n");

                if ((toTerm == terms) && isEarlyDone())
                {
                    addPayAmountTxtBox.Text = "" + ((Global.HALF_PROFIT(relAmount) + relAmount) - paidAmount);
                }
                else
                {
                    addPayAmountTxtBox.Text = "" + amountPerTerm * ((toTerm - termNo) + 1);
                }
            }
        }
    }
}
