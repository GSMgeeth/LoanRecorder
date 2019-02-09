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
        

    }
}
