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
            bool goAgain = true;
            while (goAgain)
            { 

            foreach (var item in person)
            {
                Console.WriteLine(item);

                
            }

            Console.WriteLine("Would you like to add someone to the list?");
            string userInput = Console.ReadLine().ToLower().Trim();

                if (userInput == "yes" || userInput == "y")
                {
                    
                    Console.WriteLine("Is this a persone going to be a student or staff member?");
                    string staffStudent = Console.ReadLine().ToLower().Trim();
                    if (staffStudent == "staff")
                    {
                        Console.WriteLine("Please enter staff member Name.");
                        string staffName = Console.ReadLine();

                        Console.WriteLine("Please enter staff member Address.");
                        string staffAddress = Console.ReadLine();

                        Console.WriteLine("Please enter School where this staff member works.");
                        string staffSchool = Console.ReadLine();

                        Console.WriteLine("How much does this staff member make?");
                        double staffPay = double.Parse(Console.ReadLine());

                        person.Add(new Staff(staffName, staffAddress, staffSchool, staffPay));
                    }
                    else if (staffStudent == "student")
                    {
                        Console.WriteLine("Please enter subject this student is studying.");
                        string studentSubject = Console.ReadLine();

                        Console.WriteLine("Please enter year this student is graduating.");
                        int studentGrad = int.Parse(Console.ReadLine());

                        Console.WriteLine("Please enter how much this student is paying.");
                        double studentPay = double.Parse(Console.ReadLine());

                        Console.WriteLine("Please enter student name.");
                        string studentName = Console.ReadLine();

                        Console.WriteLine("Please enter student address.");
                        string studentAddress = Console.ReadLine();

                        person.Add(new Student(studentSubject, studentGrad, studentPay, studentName, studentAddress));
                    }
                    else
                    {
                        Console.WriteLine("That was not a proper input, please type student or staff.");
                    }

                }

                string quitChoice;
                Console.WriteLine("Enter (Q)uit to exit, or any other key to run again");

                quitChoice = Console.ReadLine().Trim();

                if (quitChoice.ToLower() == "q" || quitChoice.ToLower() == "quit")
                {
                    goAgain = false;
                    Console.WriteLine("Have a nice day!");
                }

            }

        }
    }
}
