using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanRecorder.Common
{
    class Global
    {
        public static double INTEREST = 10.0;

        public static double MAX_LOAN_PERIOD = 60;

        public static int WEEKLY = 7;
        public static int FIVE_DAY = 5;
        public static int DAILY = 1;

        public static int W_LOAN_PERIOD_DAYS = (int)(MAX_LOAN_PERIOD / WEEKLY);
        public static int F_LOAN_PERIOD_DAYS = (int)(MAX_LOAN_PERIOD / FIVE_DAY);
        public static int D_LOAN_PERIOD_DAYS = (int)(MAX_LOAN_PERIOD / DAILY);
        
        public static double FULL_PROFIT(double relAmount)
        {
            return 2 * relAmount * (INTEREST / 100);
        }

        public static double HALF_PROFIT(double relAmount)
        {
            return FULL_PROFIT(relAmount) / 2;
        }
    }
}
