using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanRecorder.Role
{
    class Person
    {
        private long pid;
        private string name;
        private string nic;
        private string tel;
        private string address;
        private Guarantor [] guarantors = new Guarantor[2];

        public Person()
        {
            
        }

        public Person(Guarantor[] guarantors)
        {
            Guarantors = guarantors;
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
        internal Guarantor[] Guarantors { get => guarantors; set => guarantors = value; }
    }
}
