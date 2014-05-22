using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Array departments = Enum.GetValues(typeof(OfficeDepartment));
            Random random = new Random();

            foreach (OfficeDepartment officeDeparmentType in departments)
            {
                int randomNumber = random.Next(1, 10);
                Console.WriteLine("Department:\t{0} has {1} employees.", GetDepartmentName(officeDeparmentType), randomNumber);
            }
        }

        static string GetDepartmentName(OfficeDepartment officeDepartmentType)
        {
            string officeDepartment;
            switch (officeDepartmentType)
            {
                case OfficeDepartment.Accounting:
                    officeDepartment = "Accounting";
                    break;
                case OfficeDepartment.HumanResources:
                    officeDepartment = "Human Resources";
                    break;
                case OfficeDepartment.InformationTechnology:
                    officeDepartment = "Information Technology";
                    break;
                case OfficeDepartment.MailRoom:
                    officeDepartment = "Mail Room";
                    break;
                case OfficeDepartment.Management:
                    officeDepartment = "Management";
                    break;
                case OfficeDepartment.Shipping:
                    officeDepartment = "Shipping";
                    break;
                default:
                    officeDepartment = "?";
                    break;
            }
            return officeDepartment;

        }
    }
}
