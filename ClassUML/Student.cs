using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassUML
{
    class Student : Person
    {
        private string Program { get; set; }
        private int Year { get; set; }
        private double Fee { get; set; }

        public Student(string name, string address)
            :base(name,address)
        {

        }

        public Student(string program, int year, double fee,
            string name, string address)
            :base (name,address)
        {
            Program = program;
            Year = year;
            Fee = fee;
        }

        public override string ToString()
        {
            return $"{Name} {Address} {Program} {Year} {Fee}";
        }


    }
}
