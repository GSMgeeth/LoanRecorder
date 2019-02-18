using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanRecorder.Common
{
    class DueSearcher
    {
        public static Boolean Isdue(DateTime relDate, string type, int paidTerms, out DateTime dueDate)
        {
            dueDate = new DateTime();
            Boolean isDue = false;
            int counter = -1;

            double days = (DateTime.Today - relDate).TotalDays - 1;

            switch (type)
            {
                case "Weekly":

                    counter = (int) (days / Global.WEEKLY);
                    
                    isDue = (counter > paidTerms);
                    dueDate = relDate.AddDays(Global.WEEKLY * paidTerms + Global.WEEKLY);

                    break;

                case "FiveDay":

                    counter = (int)(days / Global.FIVE_DAY);
                    
                    isDue = (counter > paidTerms);
                    dueDate = relDate.AddDays(Global.FIVE_DAY * paidTerms + Global.FIVE_DAY);

                    break;

                case "Daily":

                    counter = (int)(days / Global.DAILY);
                    
                    isDue = (counter > paidTerms);
                    dueDate = relDate.AddDays(paidTerms * Global.DAILY + Global.DAILY);

                    break;

                default:
                    Console.WriteLine("Wrong type!");
                    break;
            }

            return isDue;
        }

        public static Boolean IsTmrw(DateTime relDate, string type, int paidTerms)
        {
            Boolean isTmrw = false;
            int counter = -1;

            double days = (DateTime.Today - relDate).TotalDays + 1;

            switch (type)
            {
                case "Weekly":

                    counter = (int)(days / Global.WEEKLY);
                    
                    isTmrw = (counter > paidTerms);

                    break;

                case "FiveDay":

                    counter = (int)(days / Global.FIVE_DAY);

                    isTmrw = (counter > paidTerms);

                    break;

                case "Daily":

                    counter = (int)(days / Global.DAILY);
                    
                    isTmrw = (counter > paidTerms);

                    break;

                default:
                    Console.WriteLine("Wrong type!");
                    break;
            }

            return isTmrw;
        }
    }
}
