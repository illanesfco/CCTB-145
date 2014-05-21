using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read Information
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter your address: ");
            string address = Console.ReadLine();
            Console.Write("Please enter your phone number: ");
            string phoneNum = Console.ReadLine();

            //Display Information
            Console.WriteLine();
            Console.WriteLine("Your information was recorded as: ");
            Console.WriteLine();
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Phone Number: " + phoneNum);
        }
    }
}
