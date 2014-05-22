using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myApp = new Program(); // calls the default constructor

            Employee headProgrammer = myApp.CreateHeadProgrammer();
            Employee bossesNephew = myApp.CreateStudentProgrammer(25000);
            Employee saitStudent = myApp.CreateStudentProgrammer(21000);

            myApp.CompareSalary(saitStudent, bossesNephew);

            myApp.ApplyRaise(headProgrammer);
            Console.WriteLine(headProgrammer.ToString());
        }

        private void ApplyRaise(Employee someone)
        {
            //Ask user for a raise amount, between 2 and 10 inclusive
            Console.Write("Enter raise percentage (2-10%): ");
            double raiseAmount = Double.Parse(Console.ReadLine());
            while (raiseAmount < 2 || raiseAmount > 10)
            {
                Console.WriteLine("Not a valid number!");
                Console.Write("Enter raise amount (2-10): ");
                raiseAmount = Double.Parse(Console.ReadLine());
            }
            raiseAmount = raiseAmount / 100; //convert into a percentage
            // Change the employee's salary
            someone.AssignBonus(raiseAmount);
            
        }

        private void CompareSalary(Employee personA, Employee personB)
        {
            double salaryDifference = personA.Salary - personB.Salary;
            //get the absolute value
            salaryDifference = Math.Abs(salaryDifference);
            string paidTheMost;
            if (personA.Salary > personB.Salary)
                paidTheMost = personA.Name;
            else
                paidTheMost = personB.Name;

            Console.WriteLine("{0} is paid ${1} more", paidTheMost, salaryDifference);
        }

        private Employee CreateStudentProgrammer(double startingWage)
        {
            Console.Write("Enter the student's name: ");
            // Create the employee object by calling the greedy constructor
            Employee cheapWorker = new Employee(Console.ReadLine(), 20, startingWage, DateTime.Today, "780.555.2003");
            return cheapWorker;
        }


        private Employee CreateHeadProgrammer()
        {
            // Instatiate (create) an object using an Initializer List
            Employee allan = new Employee()
            {
                Name = "Allan",
                Age = 27,
                Salary = 75000,
                StartingDate = new DateTime(2010, 10, 28),
                PhoneNumber = "780.555.1212"
            };
            //return the data
            return allan;
        }
    }
}
