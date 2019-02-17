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

                    //for (DateTime i = relDate; i < DateTime.Today; i.AddDays(7))
                    //{
                    //    counter++;
                    //}

                    isDue = (counter > paidTerms);
                    dueDate = relDate.AddDays(Global.WEEKLY * paidTerms + Global.WEEKLY);

                    break;

                case "FiveDay":

                    counter = (int)(days / Global.FIVE_DAY);

                    //for (DateTime i = relDate; i < DateTime.Today; i.AddDays(30))
                    //{
                    //    counter++;
                    //}

                    isDue = (counter > paidTerms);
                    dueDate = relDate.AddDays(Global.FIVE_DAY * paidTerms + Global.FIVE_DAY);

                    break;

                case "Daily":

                    counter = (int)(days / Global.DAILY);

                    //for (DateTime i = relDate; i < DateTime.Today; i.AddDays(30))
                    //{
                    //    counter++;
                    //}

                    isDue = (counter > paidTerms);
                    dueDate = relDate.AddDays(paidTerms * Global.DAILY + Global.DAILY);

                    break;

                default:
                    Console.WriteLine("Wrong type!");
                    break;
            }

            return isDue;
        }
    }
}
