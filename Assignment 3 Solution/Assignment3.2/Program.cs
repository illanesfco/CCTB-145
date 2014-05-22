using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int lessThanFiveCounter = 0;
            int greaterThanFiveCounter = 0;

            for (int outerLoop = 5; outerLoop >= 1; outerLoop--)
            {
                for (int innerLoop = 1; innerLoop <= 3; innerLoop++)
                {
                    int result = outerLoop * innerLoop;
                    if (result < 5)
                        lessThanFiveCounter++;
                    if (result > 5)
                       greaterThanFiveCounter++;
                    if (result != 5)
                        Console.WriteLine(result);
                }
            }

            Console.WriteLine("{0} calculations were less than 5: ", lessThanFiveCounter);
            Console.WriteLine("{0} calculations were greater than 5: ", greaterThanFiveCounter);

        }
    }
}
