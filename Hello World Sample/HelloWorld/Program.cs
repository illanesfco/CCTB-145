using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Tell me your name: ");

            // Create some local variables
            string name; //declaration
            name = Console.ReadLine(); //assignment
            Console.WriteLine("Hello " + name);

            int five = 5; //initialization (declaration + assignment)
            int seven = 7;
            int total = five + seven;
            Console.WriteLine("Five + Seven is " + total);

            double price = 10.95;
            int quantity = 3;
            double totalprice;
            totalprice = price * quantity;
            Console.Write(price);
            Console.Write(" times ");
            Console.Write(quantity + " equals ");
            Console.WriteLine(totalprice);
        }
    }
}
