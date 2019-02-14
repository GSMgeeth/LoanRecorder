using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanRecorder.Role
{
    public class LoanType
    {
        private int id;
        private string type_name;

        public LoanType()
        {
        }

        public LoanType(int id)
        {
            this.Id = id;
        }

        public LoanType(string type_name)
        {
            this.Type_name = type_name;
        }

        public LoanType(int id, string type_name)
        {
            this.Id = id;
            this.Type_name = type_name;
        }

        public int Id { get => id; set => id = value; }
        public string Type_name { get => type_name; set => type_name = value; }
    }
}
