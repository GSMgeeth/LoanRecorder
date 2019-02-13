using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanRecorder.Role
{
    public class Guarantor
    {
        private string name;
        private string address;
        
        public Guarantor(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }

        public Guarantor(string name)
        {
            this.Name = name;
        }

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
    }
}
