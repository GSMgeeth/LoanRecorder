using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanRecorder.Role.Views
{
    class TmrwPaymentView
    {
        private long pid;
        private long loanId;
        private string name;
        private string address;
        private string tel;
        private double relAmount;
        private int termNo;
        private double amount;

        public TmrwPaymentView(long pid, long loanId, string name, double relAmount, int termNo, double amount, string address, string tel)
        {
            Pid = pid;
            LoanId = loanId;
            Name = name;
            RelAmount = relAmount;
            TermNo = termNo;
            Amount = amount;
            Address = address;
            Tel = tel;
        }

        public long Pid { get => pid; set => pid = value; }
        public long LoanId { get => loanId; set => loanId = value; }
        public string Name { get => name; set => name = value; }
        public double RelAmount { get => relAmount; set => relAmount = value; }
        public int TermNo { get => termNo; set => termNo = value; }
        public double Amount { get => amount; set => amount = value; }
        public string Address { get => address; set => address = value; }
        public string Tel { get => tel; set => tel = value; }
    }
}
