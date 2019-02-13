using LoanRecorder.Common;
using LoanRecorder.Role;
using LoanRecorder.Role.Views;
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
        public static Boolean AddGuarantors(LinkedList<Guarantor> guarantors, long pid, long loanId)
        {
            try
            {
                Connection.updateDB("insert into guarantor (pid, loan_details_id, guar_one_name, guar_one_address, guar_two_name, guar_two_address) values (" +
                    "" + pid + "," +
                    "" + loanId + "," +
                    "'" + guarantors.First.Value.Name + "'," +
                    "'" + guarantors.First.Value.Address + "'," +
                    "'" + guarantors.Last.Value.Name + "'," +
                    "'" + guarantors.Last.Value.Address + "');");

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                MessageBox.Show("Something went wrong!\n" + ex, "Issue Loan -> Add Guarantors", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
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

        public static LinkedList<LoanType> GetAllLoanTypes()
        {
            MySqlDataReader reader = Connection.getData("select * from loan_type order by id;");

            LinkedList<LoanType> types = new LinkedList<LoanType>();

            while (reader.Read())
            {
                LoanType loanType = new LoanType();

                loanType.Id = reader.GetInt32(0);
                loanType.Type_name = reader.GetString(1);

                types.AddLast(loanType);
            }

            reader.Close();

            return types;
        }

        /*
         * Interest rate operations with the db
         * 
         */
        public static double GetInterestRate()
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

        /*
         * Loan operations with the db
         * 
         */
        public static Boolean IssueLoan(LoanDetails loan, LinkedList<Guarantor> guarantors, long pid)
        {
            if (Validation.isLoanValidForAdding(loan) && 
                Validation.isGuarantorValidForAddingAndUpdating(guarantors.First.Value) && 
                Validation.isGuarantorValidForAddingAndUpdating(guarantors.Last.Value))

                if (pid > 0)
                    try
                    {
                        Connection.updateDB("insert into loan_details (pid, rel_date, rel_amount, no_of_terms, amount_per_term, loan_type_id) values (" +
                            "" + pid + "," +
                            "'" + loan.RelDate.ToString("yyyy/MM/d") + "'," +
                            "" + loan.RelAmount + "," +
                            "" + loan.NoOfTerms + "," +
                            "" + loan.AmountPerTerm + "," +
                            "" + loan.LoanType.Id + ");");

                        MySqlDataReader reader = Connection.getData("select MAX(loan_details_id) as id from loan_details where pid=" + pid);

                        long loanId;

                        if (reader.Read())
                        {
                            loanId = reader.GetInt32(0);

                            reader.Close();

                            return AddGuarantors(guarantors, pid, loanId);
                        }
                        else
                            return false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);

                        MessageBox.Show("Something went wrong!\n" + ex, "Issue Loan", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return false;
                    }
                else
                    return false;
            else
                return false;
        }

        public static Boolean settleLoan(LoanDetails loanDetails)
        {
            return false;
        }

        public static LinkedList<LoanDetails> GetLoansByCustomer(Person person)
        {
            return null;
        }

        public static LinkedList<LoanDetails> GetAllLoans()
        {
            MySqlDataReader reader = Connection.getData("select * from loan_details order by settled asc;");

            LinkedList<LoanDetails> loans = new LinkedList<LoanDetails>();

            while (reader.Read())
            {
                LoanDetails loan = new LoanDetails();

                loan.RelDate = reader.GetDateTime("rel_date");
                loan.RelAmount = reader.GetDouble("rel_amount");
                loan.NoOfTerms = reader.GetInt16("no_of_terms");
                loan.AmountPerTerm = reader.GetDouble("amount_per_term");
                loan.LoanType = new LoanType(reader.GetInt32("loan_type_id"));

                loans.AddLast(loan);
            }

            reader.Close();

            return loans;
        }

        public static LinkedList<LoanDataGridView> GetAllLoanDetails()
        {
            MySqlDataReader reader = Connection.getData("select p.pid, ld.loan_details_id, lt.id, p.name, p.nic, ld.rel_date, " +
                        "lt.type_name, ld.rel_amount, ld.no_of_terms, count(pr.payment_id) as payment_counts, IFNULL(sum(pr.amount), 0.0) as paid, ld.amount_per_term, " +
                        "ld.settled from loan_details ld inner join person p on ld.pid=p.pid left join payment_records pr " +
                        "ON pr.loan_details_id=ld.loan_details_id inner join loan_type lt on lt.id=ld.loan_type_id " +
                        "group by ld.loan_details_id order by settled asc;");

            LinkedList<LoanDataGridView> loans = new LinkedList<LoanDataGridView>();

            while (reader.Read())
            {
                LoanDataGridView loan = new LoanDataGridView();

                loan.Pid = reader.GetInt32(0);
                loan.LoanDetailsId = reader.GetInt32(1);
                loan.LoanTypeId = reader.GetInt32(2);
                loan.Name = reader.GetString(3);
                loan.Nic = reader.GetString(4);
                loan.RelDate = reader.GetDateTime(5);
                loan.LoanTypeName = reader.GetString(6);
                loan.RelAmount = reader.GetDouble(7);
                loan.NoOfTerms = reader.GetInt32(8);
                loan.PaidCount = reader.GetInt32(9);
                loan.PaidAmount = reader.GetDouble(10);
                loan.AmountPerTerm = reader.GetDouble(11);

                loans.AddLast(loan);
            }

            reader.Close();

            return loans;
        }

        public static LinkedList<LoanDataGridView> GetAllLoanDetailsByCutomerName(string name)
        {
            MySqlDataReader reader = Connection.getData("select p.pid, ld.loan_details_id, lt.id, p.name, p.nic, ld.rel_date, " +
                        "lt.type_name, ld.rel_amount, ld.no_of_terms, count(pr.payment_id) as payment_counts, IFNULL(sum(pr.amount), 0.0) as paid, ld.amount_per_term, " +
                        "ld.settled from loan_details ld inner join person p on ld.pid=p.pid left join payment_records pr " +
                        "ON pr.loan_details_id=ld.loan_details_id inner join loan_type lt on lt.id=ld.loan_type_id " +
                        "where p.name like '%" + name + "%' group by ld.loan_details_id order by settled asc;");

            LinkedList<LoanDataGridView> loans = new LinkedList<LoanDataGridView>();

            while (reader.Read())
            {
                LoanDataGridView loan = new LoanDataGridView();

                loan.Pid = reader.GetInt32(0);
                loan.LoanDetailsId = reader.GetInt32(1);
                loan.LoanTypeId = reader.GetInt32(2);
                loan.Name = reader.GetString(3);
                loan.Nic = reader.GetString(4);
                loan.RelDate = reader.GetDateTime(5);
                loan.LoanTypeName = reader.GetString(6);
                loan.RelAmount = reader.GetDouble(7);
                loan.NoOfTerms = reader.GetInt32(8);
                loan.PaidCount = reader.GetInt32(9);
                loan.PaidAmount = reader.GetDouble(10);
                loan.AmountPerTerm = reader.GetDouble(11);

                loans.AddLast(loan);
            }

            reader.Close();

            return loans;
        }

        public static double GetRate()
        {
            MySqlDataReader reader = Connection.getData("select interest_percentage from interest where interest_id=1");

            while (reader.Read())
            {
                double rate = reader.GetDouble(0);
                reader.Close();
                return rate;
            }

            reader.Close();

            return -23.0;
        }
    }
}
