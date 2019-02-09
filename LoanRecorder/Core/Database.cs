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
                MySqlDataReader reader = Connection.getData("select * from person where name='" + name + "'");

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
            MySqlDataReader reader = Connection.getData("select * from person;");

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
    }
}
