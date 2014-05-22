using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFlow1
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Write the code that will run the samples...
            Program myApp = new Program(); // create a new object based on this class

            myApp.IfStatementSample(); // call (i.e.: execute) the method
            myApp.WhileStatementSamples();
            myApp.ForStatementSameple();
            myApp.ListDivisibleBy(3);
            int someNumber;
            Console.Write("Enter a small number between 2 and 20: ");
            someNumber = int.Parse(Console.ReadLine());
            myApp.ListDivisibleBy(someNumber);
            myApp.EnumSample(Color.Green); // passing in a literal value from my enum

            Console.WriteLine("Press [enter] to exit...");
            Console.ReadLine();
        } // end of the Main() method

        private void EnumSample(Color favoriteColor)
        {
            Console.WriteLine("Enumeration Sample...");
            
            switch (favoriteColor)
            {
                case Color.Red:
                    Console.WriteLine("Your color is red.");
                    break;
                case Color.Blue:
                    Console.WriteLine("Your color is blue.");
                    break;
                case Color.Green:
                    Console.WriteLine("Your color is green.");
                    break;
                default:
                    Console.WriteLine("You entered a different color.");
                    Console.WriteLine(favoriteColor);
                    break;
            }

        }
                
        public void IfStatementSample()
        {
            Console.WriteLine("If Statement Sample...");
            Console.Write("Enter your age: ");
            //string stringAge = Console.ReadLine();
            //int age = int.Parse(stringAge); //Convert the typed number to an int
            int age = int.Parse(Console.ReadLine());

            if (age >= 65)
                Console.WriteLine("You are a senior.");
            else if (age >= 18)
                Console.WriteLine("You are an adult.");
            else
                Console.WriteLine("You are not an adult.");
        } // end of IfStatementSample() method

        private void WhileStatementSamples()
        {
            Console.WriteLine("While and Do-While Samples...");

            int counter = 10;
            while (counter > 0)
            {
                //these statements occur 0 or more times
                Console.WriteLine(counter);
                counter--;
            } 

            int age = 0;
            do
            {
                //these statements occur 1 or more times
                Console.Write("Enter your age: ");
                age = int.Parse(Console.ReadLine());
            } while (age < 1 || age > 100);
            string message;
            //message = string.Format("You are {0} years old!", age);
            //Console.WriteLine(message);
            Console.WriteLine("You are {0} years old!", age);
        }

        private void ForStatementSameple()
        {
            Console.WriteLine("For Sample...");
            for (int counter = 1; counter <= 10; counter++)
            {
                Console.WriteLine(counter);
            }
        }

        private void ListDivisibleBy(int divisor)
        {
            Console.WriteLine("List all the numbers from 1 to 100 that are divisible by {0}", divisor);
            for (int i = 1; i <= 100; i++)
            {
                if (i % divisor == 0)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();
        }

    } // end of the Program class

} // end of the namespace for this file's code
