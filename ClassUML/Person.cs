using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassUML
{
    abstract class Person
    {
        protected string Name { get; set; }
        protected string Address { get; set; }

        public Person()
        {

        }

        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }
        public override string ToString()
        {
            return $"{Name} {Address}";
        }



    }

    

}
