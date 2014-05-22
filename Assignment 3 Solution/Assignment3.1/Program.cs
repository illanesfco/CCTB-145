using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int evenNumberTotal = 0;
            do
            {
                Console.Write("Please enter a number between 1 and 100: ");
                number = int.Parse(Console.ReadLine());
            } while (number < 1 || number > 100);

            for (int currentNumber = 1; currentNumber <= number; currentNumber++)
            {
                if (IsEvenNumber(currentNumber))
                {
                    evenNumberTotal += currentNumber;
                    Console.Write("{0} ", currentNumber);
                    if (currentNumber != number)
                        Console.Write("+ ");
                }
                
            }

            Console.WriteLine("= {0}", evenNumberTotal);
          
        }

        static public bool IsEvenNumber(int number)
        {
            return number % 2 == 0;
        }
    }
}
