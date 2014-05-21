using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesValuesandDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Order of operations - arithmetic operators
            double result = 5 + 6 * 4 + 1;
            /*               |   |   |   |
             *               |   \  /    |
             *               |    24     |
             *               |     |     |
             *               \     /     |
             *                 29        |
             *                  |        |
             *                  \        /
             *                      30
             */
            Console.WriteLine("The result is " + result);

            //What does casting really do?
            char singleDigit = '5';
            int simpleNumber = 25;
            //The result of casting...
            Console.WriteLine("Casting '5'...");
            Console.WriteLine((int)singleDigit);
            Console.WriteLine("Casting 25...");
            Console.WriteLine((double)simpleNumber);
            //The result of converting
            Console.WriteLine("Converting '5'...");
            Console.WriteLine(Convert.ToInt32(singleDigit));
            Console.WriteLine("Converting 25...");
            Console.WriteLine(Convert.ToDouble(simpleNumber));
            // "alternate" way of converting using the Parse method
            Console.WriteLine("Converting '5' using int.Parse()");
            //Console.WriteLine(int.Parse(singleDigit)); //Can't parse a single char
            Console.WriteLine(int.Parse(singleDigit.ToString())); //Can parse a string
            Console.WriteLine("The value in the variable singleDigit is " + singleDigit.ToString());
            Console.WriteLine("Converting '5' after calling .toString()...");
            Console.WriteLine(Convert.ToInt32(singleDigit.ToString()));
            

            //Variables of various data types, with values

        }
    }
}
