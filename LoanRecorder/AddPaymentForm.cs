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

        public AddPaymentForm()
        {
            InitializeComponent();
        }

        public AddPaymentForm(Person person, int termNo, double amount)
        {
            InitializeComponent();

            this.person = person;
            this.termNo = termNo;
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

        }

        private void addPayDatePicker_Validated(object sender, EventArgs e)
        {

        }
    }
}
