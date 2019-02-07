using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanRecorder.Role
{
    class LoanDetails
    {
        private DateTime relDate;
        private double relAmount;
        private int noOfTerms;
        private double amountPerTerm;
        private LoanType loanType;

        public LoanDetails()
        {
        }

        public LoanDetails(DateTime relDate, double relAmount)
        {
            RelDate = relDate;
            RelAmount = relAmount;
        }

        public LoanDetails(DateTime relDate, double relAmount, int noOfTerms, double amountPerTerm, LoanType loanType)
        {
            RelDate = relDate;
            RelAmount = relAmount;
            NoOfTerms = noOfTerms;
            AmountPerTerm = amountPerTerm;
            LoanType = loanType;
        }

        public DateTime RelDate { get => relDate; set => relDate = value; }
        public double RelAmount { get => relAmount; set => relAmount = value; }
        public int NoOfTerms { get => noOfTerms; set => noOfTerms = value; }
        public double AmountPerTerm { get => amountPerTerm; set => amountPerTerm = value; }
        internal LoanType LoanType { get => loanType; set => loanType = value; }
    }
}
