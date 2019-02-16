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
    public partial class PaymentDetailsForm : Form
    {
        private long pid, loanId;

        public PaymentDetailsForm()
        {
            InitializeComponent();
        }

        public PaymentDetailsForm(long pid, long loanId, string name, string nic, DateTime relDate, double relAmount, double paidAmount, double toPay, double profit)
        {
            InitializeComponent();

            this.pid = pid;
            this.loanId = loanId;

            detPayCustNameTxtBox.Text = name;
            detPayCustNicTxtBox.Text = nic;
            detPayRelAmount.Text = "" + relAmount;
            detPayRelDatePicker.Value = relDate;
            detPayPaidAmountTxtBox.Text = "" + paidAmount;
            detPayToPayTxtBox.Text = "" + toPay;
            detPayProfitTxtBox.Text = "" + profit;
        }

        private void PaymentDetailsForm_Load(object sender, EventArgs e)
        {
            fillPaymentDetailsDataGrid();
        }

        private void fillPaymentDetailsDataGrid()
        {
            DataTable table = new DataTable();

            loanDetailsDataGrid.DataSource = null;

            LinkedList<PaymentRecords> payments = Database.GetPaymentsByLoan(pid, loanId);

            table.Columns.Add("paymentId", typeof(long));
            table.Columns.Add("Amount", typeof(double));
            table.Columns.Add("Paid Date", typeof(DateTime));
            table.Columns.Add("Term No", typeof(int));

            foreach (PaymentRecords payment in payments)
            {
                DataRow row = table.NewRow();

                Console.WriteLine("\n\n");
                Console.WriteLine(payment.PaymentId);
                Console.WriteLine("\n\n");

                row[0] = payment.PaymentId;
                row[1] = payment.Amount;
                row[2] = payment.PaidDate;
                row[3] = payment.TermNo;
                
                table.Rows.Add(row);
            }
            
            loanDetailsDataGrid.DataSource = table;

            loanDetailsDataGrid.Columns[0].Visible = false;
        }
    }
}
