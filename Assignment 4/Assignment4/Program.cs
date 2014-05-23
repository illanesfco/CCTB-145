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
            Student fran = new Student(0001, Console.ReadLine(), "1234");
            fran.OutputStudentDetails();
            Console.WriteLine("Adding a course to student's history");
            fran.IncreaseCoursesTaken();
            fran.OutputStudentDetails();

            
        }
    }
}
