using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassUML
{
    class Staff : Person
    {

        private string School { get; set; }
        private double Pay { get; set; }

        public Staff(string name, string address)
            :base(name,address)
        {

        }

        public Staff(string name, string address,
            string school, double pay)
            :base(name,address)
        {
            School = school;
            Pay = pay;
        }
        public override string ToString()
        {
            return $"{Name}{Address}{School} {Pay}";
        }
    }
}
