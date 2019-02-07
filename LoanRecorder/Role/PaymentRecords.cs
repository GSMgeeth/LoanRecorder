using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanRecorder.Role
{
    class PaymentRecords
    {
        private long paymentId;
        private double amount;
        private DateTime paidDate;
        private int termNo;

        public PaymentRecords()
        {
        }

        public PaymentRecords(long paymentId)
        {
            this.PaymentId = paymentId;
        }

        public PaymentRecords(double amount, DateTime paidDate, int termNo)
        {
            this.Amount = amount;
            this.PaidDate = paidDate;
            this.TermNo = termNo;
        }

        public PaymentRecords(long paymentId, double amount, DateTime paidDate, int termNo)
        {
            this.PaymentId = paymentId;
            this.Amount = amount;
            this.PaidDate = paidDate;
            this.TermNo = termNo;
        }

        public long PaymentId { get => paymentId; set => paymentId = value; }
        public double Amount { get => amount; set => amount = value; }
        public DateTime PaidDate { get => paidDate; set => paidDate = value; }
        public int TermNo { get => termNo; set => termNo = value; }
    }
}
