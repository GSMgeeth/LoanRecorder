using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanRecorder.Role
{
    public class Interest
    {
        private int interestId;
        private double interestPercentage;

        public Interest()
        {
        }

        public Interest(double interestPercentage)
        {
            this.InterestPercentage = interestPercentage;
        }

        public Interest(int interestId, double interestPercentage)
        {
            this.InterestId = interestId;
            this.InterestPercentage = interestPercentage;
        }

        public int InterestId { get => interestId; set => interestId = value; }
        public double InterestPercentage { get => interestPercentage; set => interestPercentage = value; }
    }
}
