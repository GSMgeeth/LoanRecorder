using LoanRecorder.Common;
using LoanRecorder.Role;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanRecorder.Core
{
    class Database
    {
        /*
         * Person operations with the db
         * 
         */
        public static Boolean AddPerson(Person person)
        {
            if (Validation.isPersonValidForAdding(person))
            {
                try
                {
                    Connection.updateDB("insert into person (name, nic, tel, address) values (" +
                    "'" + person.Name + "'," +
                    "'" + person.Nic + "'," +
                    "'" + person.Tel + "'," +
                    "'" + person.Address + "');");

                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                    MessageBox.Show("Something went wrong!\n" + ex.Message, "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static Boolean UpdatePerson(Person person)
        {
            if (Validation.isPersonValidForUpdating(person))
            {
                try
                {
                    Connection.updateDB("update person set " +
                        "name='" + person.Name + "'," +
                        "nic='" + person.Nic + "'," +
                        "tel='" + person.Tel + "'," +
                        "address='" + person.Address + "' where pid=" + person.Pid + ";");

                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                    MessageBox.Show("Something went wrong!\n" + ex.Message, "Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static Boolean DeletePerson(long pid)
        {
            if (pid > 0)
            {
                try
                {
                    Connection.updateDB("delete from person where pid=" + pid);

                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                    MessageBox.Show("Something went wrong!\n" + ex.Message, "Delete Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static Person GetPersonById(long pid)
        {
            if (pid > 0)
            {
                MySqlDataReader reader = Connection.getData("select * from person where pid=" + pid);

                Person person = null;

                while (reader.Read())
                {
                    person = new Person();

                    person.Pid = reader.GetInt32(0);
                    person.Name = reader.GetString(1);
                    person.Nic = reader.GetString(2);
                    person.Tel = reader.GetString(3);
                    person.Address = reader.GetString(4);
                }

                reader.Close();

                return person;
            }
            else
            {
                return null;
            }
        }

        public static LinkedList<Person> GetPersonsByName(string name)
        {
            if (!name.Equals(""))
            {
                MySqlDataReader reader = Connection.getData("select * from person where name like '%" + name + "%' order by pid");

                LinkedList<Person> persons = new LinkedList<Person>();

                while (reader.Read())
                {
                    Person person = new Person();

                    person.Pid = reader.GetInt32(0);
                    person.Name = reader.GetString(1);
                    person.Nic = reader.GetString(2);
                    person.Tel = reader.GetString(3);
                    person.Address = reader.GetString(4);

                    persons.AddLast(person);
                }

                reader.Close();

                return persons;
            }
            else
            {
                return null;
            }
        }

        public static Person GetPersonByNic(string nic)
        {
            if (!nic.Equals(""))
            {
                MySqlDataReader reader = Connection.getData("select * from person where nic='" + nic + "'");

                Person person = null;

                while (reader.Read())
                {
                    person = new Person();

                    person.Pid = reader.GetInt32(0);
                    person.Name = reader.GetString(1);
                    person.Nic = reader.GetString(2);
                    person.Tel = reader.GetString(3);
                    person.Address = reader.GetString(4);
                }

                reader.Close();

                return person;
            }
            else
            {
                return null;
            }
        }

        public static Person GetPersonByTel(string tel)
        {
            if (!tel.Equals(""))
            {
                MySqlDataReader reader = Connection.getData("select * from person where tel='" + tel + "'");

                Person person = null;

                while (reader.Read())
                {
                    person = new Person();

                    person.Pid = reader.GetInt32(0);
                    person.Name = reader.GetString(1);
                    person.Nic = reader.GetString(2);
                    person.Tel = reader.GetString(3);
                    person.Address = reader.GetString(4);
                }

                reader.Close();

                return person;
            }
            else
            {
                return null;
            }
        }

        public static LinkedList<Person> GetAllPersons()
        {
            MySqlDataReader reader = Connection.getData("select * from person order by pid;");

            LinkedList<Person> persons = new LinkedList<Person>();

            while (reader.Read())
            {
                Person person = new Person();

                person.Pid = reader.GetInt32(0);
                person.Name = reader.GetString(1);
                person.Nic = reader.GetString(2);
                person.Tel = reader.GetString(3);
                person.Address = reader.GetString(4);

                persons.AddLast(person);
            }

            reader.Close();

            return persons;
        }

        /*
         * Guarantor operations with the db
         * 
         */
        public static Boolean AddGuarantor(Guarantor guarantor)
        {
            return true;
        }

        public static Boolean UpdateGuarantor(Guarantor guarantor)
        {
            return true;
        }

        public static LinkedList<Guarantor> GetGuarantorsByPersonId(long pid)
        {
            return null;
        }

        public static LinkedList<Guarantor> GetGuarantorsByPersonIdAndName(long pid, string guarantorName)
        {
            return null;
        }

        /*
         * Loan Type operations with the db
         * 
         */
        public static Boolean AddLoanType(LoanType loanType)
        {
            if (Validation.isLoanTypeValidForAdding(loanType))
            {
                try
                {
                    Connection.updateDB("insert into loan_type (type_name) values (" +
                    "'" + loanType.Type_name + "');");

                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                    MessageBox.Show("Something went wrong!\n" + ex.Message, "Add Loan Type", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static LoanType GetLoanTypeByName(string name)
        {
            if (!name.Equals(""))
            {
                MySqlDataReader reader = Connection.getData("select * from loan_type where type_name='" + name + "'");

                LoanType loanType = null;

                while (reader.Read())
                {
                    loanType = new LoanType();

                    loanType.Id = reader.GetInt32(0);
                    loanType.Type_name = reader.GetString(1);
                }

                reader.Close();

                return loanType;
            }
            else
            {
                return null;
            }
        }

        /*
         * Interest rate operations with the db
         * 
         */
        public static double getInterestRate()
        {
            MySqlDataReader reader = Connection.getData("select interest_percentage from interest where interest_id=1;");

            double rate = 0.0;

            while (reader.Read())
            {
                rate = reader.GetDouble(0);
            }

            reader.Close();

            return rate;
        }
        
        public static Boolean ChangeRate(double rate)
        {
            try
            {
                Connection.updateDB("update interest set interest_percentage=" + rate + " where interest_id=1");

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                MessageBox.Show("Something went wrong!\n" + ex.Message, "Change Rate", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }
    }
}
