using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookAssignmentProblem
{
    public static class PersonDetials
    {
        public static void CreatePersonContact()
        {
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("enter the Phone number: ");
            long phoneNumber = long.Parse(Console.ReadLine());

            Console.Write("Enter the zipcode: ");
            int zipCode = int.Parse(Console.ReadLine());

            Console.Write("Enter the city: ");
            string city = Console.ReadLine();
        }
    }
}
