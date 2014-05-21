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

        } // end of the Main() method

        public void IfStatementSample()
        {
            Console.WriteLine("If Statement Sample...");
            Console.Write("Enter your age: ");
            string stringAge = Console.ReadLine();
            int age = int.Parse(stringAge); //Convert the typed number to an int

            if (age >= 18)
                Console.WriteLine("You are an adult.");
            else
                Console.WriteLine("You are not an adult.");
        } // end of IfStatementSample() method

    } // end of the Program class

} // end of the namespace for this file's code
