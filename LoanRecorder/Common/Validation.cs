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
