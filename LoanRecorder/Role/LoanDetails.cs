using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanRecorder.Role
{
    public class LoanDetails
    {
        private DateTime relDate;
        private double relAmount;
        private int noOfTerms;
        private double amountPerTerm;
        private LoanType loanType;
        private double profit;
        private Guarantor[] guarantors = new Guarantor[2];

        public LoanDetails()
        {
        }

        public LoanDetails(DateTime relDate, double relAmount)
        {
            RelDate = relDate;
            RelAmount = relAmount;
        }

        public LoanDetails(DateTime relDate, double relAmount, double profit, int noOfTerms, double amountPerTerm, LoanType loanType)
        {
            RelDate = relDate;
            RelAmount = relAmount;
            NoOfTerms = noOfTerms;
            AmountPerTerm = amountPerTerm;
            LoanType = loanType;
            Profit = profit;
        }

        public LoanDetails(Guarantor[] guarantors)
        {
            Guarantors = guarantors;
        }

        public DateTime RelDate { get => relDate; set => relDate = value; }
        public double RelAmount { get => relAmount; set => relAmount = value; }
        public int NoOfTerms { get => noOfTerms; set => noOfTerms = value; }
        internal Guarantor[] Guarantors { get => guarantors; set => guarantors = value; }
        public double AmountPerTerm { get => amountPerTerm; set => amountPerTerm = value; }
        internal LoanType LoanType { get => loanType; set => loanType = value; }
        public double Profit { get => profit; set => profit = value; }
    }
}
