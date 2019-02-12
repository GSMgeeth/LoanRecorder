using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanRecorder.Role.Views
{
    class LoanDataGridView
    {
        private long pid;
        private long loanDetailsId;
        private int loanTypeId;
        private string name;
        private string nic;
        private string loanTypeName;
        private DateTime relDate;
        private double relAmount;
        private int noOfTerms;
        private int paidCount;
        private double paidAmount;
        private double toPay;
        private double profit;

        public LoanDataGridView()
        {
        }

        public LoanDataGridView(long pid, long loanDetailsId, int loanTypeId, string name, string nic, string loanTypeName, DateTime relDate, double relAmount, int noOfTerms, int paidCount, double paidAmount, double toPay, double profit)
        {
            Pid = pid;
            LoanDetailsId = loanDetailsId;
            LoanTypeId = loanTypeId;
            Name = name;
            Nic = nic;
            LoanTypeName = loanTypeName;
            RelDate = relDate;
            RelAmount = relAmount;
            NoOfTerms = noOfTerms;
            PaidCount = paidCount;
            PaidAmount = paidAmount;
            ToPay = toPay;
            Profit = profit;
        }

        public long Pid { get => pid; set => pid = value; }
        public long LoanDetailsId { get => loanDetailsId; set => loanDetailsId = value; }
        public int LoanTypeId { get => loanTypeId; set => loanTypeId = value; }
        public string Name { get => name; set => name = value; }
        public string Nic { get => nic; set => nic = value; }
        public string LoanTypeName { get => loanTypeName; set => loanTypeName = value; }
        public DateTime RelDate { get => relDate; set => relDate = value; }
        public double RelAmount { get => relAmount; set => relAmount = value; }
        public int NoOfTerms { get => noOfTerms; set => noOfTerms = value; }
        public int PaidCount { get => paidCount; set => paidCount = value; }
        public double PaidAmount { get => paidAmount; set => paidAmount = value; }
        public double ToPay { get => toPay; set => toPay = value; }
        public double Profit { get => profit; set => profit = value; }
    }
}
