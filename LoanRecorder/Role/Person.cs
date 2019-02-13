using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanRecorder.Role
{
    public class Person
    {
        private long pid;
        private string name;
        private string nic;
        private string tel;
        private string address;
        private LinkedList<LoanDetails> loanDetails;
        private LinkedList<PaymentRecords> paymentRecords;

        public Person()
        {
            paymentRecords = new LinkedList<PaymentRecords>();
        }
        
        public Person(LinkedList<LoanDetails> loanDetails)
        {
            LoanDetails = loanDetails;
        }

        public Person(long pid, string name, string nic)
        {
            Pid = pid;
            Name = name;
            Nic = nic;
        }

        public Person(long pid, LinkedList<LoanDetails> loanDetails) : this(pid)
        {
            LoanDetails = loanDetails;
        }

        public Person(LinkedList<PaymentRecords> paymentRecords)
        {
            PaymentRecords = paymentRecords;
        }
        
        public Person(long pid, string name, string nic, string tel, string address)
        {
            this.Pid = pid;
            this.Name = name;
            this.Nic = nic;
            this.Tel = tel;
            this.Address = address;
        }

        public Person(string name, string nic, string tel, string address)
        {
            this.Name = name;
            this.Nic = nic;
            this.Tel = tel;
            this.Address = address;
        }

        public Person(long pid)
        {
            this.Pid = pid;
        }

        public long Pid { get => pid; set => pid = value; }
        public string Name { get => name; set => name = value; }
        public string Nic { get => nic; set => nic = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Address { get => address; set => address = value; }
        internal LinkedList<PaymentRecords> PaymentRecords { get => paymentRecords; set => paymentRecords = value; }
        internal LinkedList<LoanDetails> LoanDetails { get => loanDetails; set => loanDetails = value; }
    }
}
