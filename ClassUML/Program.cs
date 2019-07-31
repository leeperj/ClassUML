using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassUML
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> person = new List<Person>
            {
                new Student("English",2021,51000,"Ryan Martin","\t1935 Princeton Dr"),
                new Student("Math",2022,60000,"Mary Sanders","\t2020 Rose Arbor"),
                new Student("History",2040,100000,"Timmy Burch","\t3330 Penrose Ct."),
                new Staff("Marie Jones","\t819 Circleview","St. Peters",45000),
                new Staff("Donald Simmons","\t664 Elm St.","Harvard",75000)

            };

            foreach (var item in person)
            {
                Console.WriteLine(item);

                
            }

            

        }
    }
}
