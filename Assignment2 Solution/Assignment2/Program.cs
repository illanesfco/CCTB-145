using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool attendingSchool = true;
            bool workingFullTime = false;
            string name = "Francisco Illanes";
            string city = "Calgary";
            int yearsCollege = 2;
            int yearsUniversity = 4;

            int totalPostSecondaryYears = yearsCollege + yearsUniversity;
            bool moreThan4YearsPostSecondary = totalPostSecondaryYears > 4;
            bool attendingSchoolandWorking = attendingSchool && workingFullTime;
            bool hardWorkingOrSmart = attendingSchool || workingFullTime;

            Console.WriteLine(name + " from " + city);
            Console.WriteLine("Attending School and Working: " + attendingSchoolandWorking);
            Console.WriteLine("More than 4 years of Post Secondary: " + moreThan4YearsPostSecondary);
            Console.WriteLine("Hard Working or Smart: " + hardWorkingOrSmart);

        }
    }
}
