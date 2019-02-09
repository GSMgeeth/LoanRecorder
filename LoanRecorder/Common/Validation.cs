using LoanRecorder.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanRecorder.Common
{
    class Validation
    {
        private string msg = "";

        public static Boolean isPersonValidForAdding(Person person)
        {
            if (person != null)
                if (!person.Name.Equals(""))
                    if (!person.Nic.Equals(""))
                        if (!person.Tel.Equals(""))
                            if (!person.Address.Equals(""))
                                return true;
                            else
                                return false;
                        else
                            return false;
                    else
                        return false;
                else
                    return false;
            else
                return false;
        }

        public static Boolean isPersonValidForUpdating(Person person)
        {
            if (person != null)
                if (person.Pid > 0)
                    if (!person.Name.Equals(""))
                        if (!person.Nic.Equals(""))
                            if (!person.Tel.Equals(""))
                                if (!person.Address.Equals(""))
                                    return true;
                                else
                                    return false;
                            else
                                return false;
                        else
                            return false;
                    else
                        return false;
                else
                    return false;
            else
                return false;
        }

        public static Boolean isLoanValidForAdding(LoanDetails loan)
        {
            if (loan != null)
                if (!loan.RelDate.Equals(null))
                    if (loan.RelAmount >= 0.00)
                        if (loan.NoOfTerms > 0)
                            if (loan.LoanType.Id > 0)
                                if (loan.Guarantors.Length == 2)
                                    return true;
                                else
                                    return false;
                            else
                                return false;
                        else
                            return false;
                    else
                        return false;
                else
                    return false;
            else
                return false;
        }

        public static Boolean isGuarantorValidForAddingAndUpdating(Guarantor guarantor)
        {
            if (guarantor != null)
                if (!guarantor.Name.Equals(""))
                    if (!guarantor.Address.Equals(""))
                        return true;
                    else
                        return false;
                else
                    return false;
            else
                return false;
        }

        public static Boolean isLoanTypeValidForAdding(LoanType loanType)
        {
            if (loanType != null)
                if (!loanType.Type_name.Equals(""))
                    return true;
                else
                    return false;
            else
                return false;
        }

        public static Boolean isLettersOnly(String text)
        {
            return !text.Any(char.IsDigit);
        }

        public static Boolean isNumbersOnly(string text)
        {
            return text.All(char.IsDigit);
        }

        public static Boolean isPhoneNumber(string text)
        {
            return ((text.Length == 10) && (text.All(char.IsDigit)));
        }

        public static Boolean isDouble(String text)
        {
            double dbl;

            return Double.TryParse(text, out dbl);
        }

        public static Boolean isRate(string text)
        {
            if (isDouble(text))
                return ((Double.Parse(text) <= 100.00) && (Double.Parse(text) >= 0.00));
            else
                return false;
        }

        public static Boolean isInteger(String text)
        {
            int integer;

            return Int32.TryParse(text, out integer);
        }

        public static Boolean isNic(string text)
        {
            if ((text.Length == 10) && ((text[text.Length - 1] == 'v') || (text[text.Length - 1] == 'V')))
                if (text.Substring(0, text.Length - 1).All(char.IsDigit))
                    return true;
                else
                    return false;
            else
                return false;
        }

        public static Boolean isFuture(DateTime dateTime)
        {
            return (dateTime > DateTime.Now);
        }
    }
}
