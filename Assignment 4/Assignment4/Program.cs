using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myApp = new Program();
            Console.Write("Please enter the name of the new student: ");
            Student student = new Student(0001, Console.ReadLine(), "1234");
            student.OutputStudentDetails();

            string choice;
            do
            {
                Console.Write("Would you like to add a course for {0} (Y/N)? ", student.Name);
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "Y":
                        {
                            Console.WriteLine("Adding a course to {0}'s history", student.Name);
                            student.IncreaseCoursesTaken();
                            break;
                        }
                    case "N":
                        {
                            Console.WriteLine("No course was added for {0}", student.Name);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("You have made an invalid selection");
                            break;
                        }
                }
                
            } while (!choice.Equals("Y") && !choice.Equals("N"));
            
            student.OutputStudentDetails();
            
        }
    }
}
