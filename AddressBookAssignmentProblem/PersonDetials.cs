using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookAssignmentProblem
{
    public class PersonDetials
    {
        //Creating a list 
        public static List<Contact> contacts = new List<Contact>();
        //Creating a Dictionary
        Dictionary<string, List<Contact>> book = new Dictionary<string, List<Contact>>();
        //Method for Adding Person
        public void AddPerson()
        {
            Contact contact = new Contact();

            Console.Write("Enter First Name: ");
            contact.firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            contact.lastName = Console.ReadLine();

            Console.Write("enter the Phone number: ");
            contact.phoneNumber = long.Parse(Console.ReadLine());

            Console.Write("Enter the zipcode: ");
            contact.zipCode = int.Parse(Console.ReadLine());

            Console.Write("Enter the city: ");
            contact.city = Console.ReadLine();

            contacts.Add(contact);
        }
        //For Displaying The Contact of A person
        public void listPerson()
        {
            foreach (var data in contacts)
            {
                Console.WriteLine("FirstName: " + data.firstName);
                Console.WriteLine("LastName: " + data.lastName);
                Console.WriteLine("PhoneNumber: " + data.phoneNumber);
                Console.WriteLine("City: " + data.city);
                Console.WriteLine("Zipcode: " + data.zipCode);

            }
        }
        //Method For Editing contact Detials of a Person
        public void EditPerson()
        {
            Console.Write("enter the name to edit: ");
            string editname = Console.ReadLine();
            foreach (var data in contacts)
            {
                if (contacts.Contains(data))
                {
                    if (data.firstName == editname)
                    {
                        Console.WriteLine("FirstName Exists in Contact");
                        Console.Write("enter the Phone number: ");
                        data.phoneNumber = long.Parse(Console.ReadLine());

                        Console.Write("Enter the zipcode: ");
                        data.zipCode = int.Parse(Console.ReadLine());

                        Console.Write("Enter the city: ");
                        data.city = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("FirstName does not Exists in Contact");
                        AddPerson();
                    }
                }
            }
        }
        //Method for deleting a person contact
        public void DeleteContact()
        {
            Console.Write("enter the name to delete: ");
            string personName = Console.ReadLine();
            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i].firstName == personName)
                {
                    Console.WriteLine("Record Of {0} Deleted Successfully", contacts[i].firstName);
                    contacts.RemoveAt(i);
                }
            }
        }
        //
        public void MultipleContacts()
        {
            Console.WriteLine("Enter The Number of Contacts To Add");
            int A = int.Parse(Console.ReadLine());
            while (A > 0)
            {
                AddPerson();
                A--;
            }
        }
        public void NewUser()
        {
            Console.WriteLine("Enter the Bookname: ");
            string Bookname = Console.ReadLine();
            Console.WriteLine("Enter The Number of Contacts To Add");
            int A = int.Parse(Console.ReadLine());
            while (A > 0)
            {
                A--;
                AddPerson();
            }
            book.Add(Bookname, contacts.ToList());
        }
        public void Display()
        {
            foreach (var pair in book.Keys)
            {
                Console.WriteLine("Address Book Name " + pair);
                foreach (Contact kvp in book[pair])
                {
                    Console.WriteLine("First Name: " + kvp.firstName);
                    Console.WriteLine("Last Name: " + kvp.lastName);
                    Console.WriteLine("City : " + kvp.city);
                    Console.WriteLine("Zip : " + kvp.zipCode);
                    Console.WriteLine("Phone Number: " + kvp.phoneNumber);
                }
            }
        }
        public void DuplicateContact()
        {
            Console.WriteLine("enter the name to check: ");
            string personName = Console.ReadLine();
            Console.WriteLine("Enter phonenumber");
            long phnno = long.Parse(Console.ReadLine());
            bool check = contacts.Any(e => e.firstName == personName && e.phoneNumber == phnno);
            if (check)
            {
                Console.WriteLine("contact is present");
            }
            else
            {
                Console.WriteLine("Contact is not present");
                NewUser();
            }
        }
        public void SearchPersonByCity()
        {
            Console.WriteLine("enter the name to search: ");
            string personName = Console.ReadLine();
            Console.WriteLine("enter the city to search: ");
            string cityname = Console.ReadLine();
            foreach (var pair in book.Keys)
            {
                Console.WriteLine("Address Book Name " + pair);
                foreach (var data in book[pair].FindAll(e => e.city == cityname && e.firstName == personName))
                {
                    Console.WriteLine("The Contact Details of " + data.city + " are\n:" + data.firstName + " " + data.lastName + " " + data.zipCode + " " + data.phoneNumber);
                }
            }
        }
        public void ViewPersonsByCity()
        {
            Console.WriteLine("enter the city to search: ");
            string cityname = Console.ReadLine();
            foreach (var data in contacts.FindAll(e => e.city == cityname))
            {
                Console.WriteLine("The Contact Details of " + data.city + " are\n:" + data.firstName + " " + data.lastName + " " + data.zipCode + " " + data.phoneNumber);
            }
        }
        public void CountPersonByCity()
        {
            Console.WriteLine("enter the city to search: ");
            string cityname = Console.ReadLine();
            int count = 0;
            foreach (var items in contacts.FindAll(e => e.city == cityname))
            {
                count++;
            }
            Console.WriteLine("No of contacts {0} in city {1}", count, cityname);
        }
        public void SortPersonName()
        {
            foreach (var items in contacts.OrderBy(e => e.firstName))
            {
                Console.WriteLine("First Name: " + items.firstName);
                Console.WriteLine("Last Name: " + items.lastName);
                Console.WriteLine("City : " + items.city);
                Console.WriteLine("Zip : " + items.zipCode);
                Console.WriteLine("Phone Number: " + items.phoneNumber);
            }
        }
        public void SortbyCityName()
        {
            foreach (var items in contacts.OrderBy(e => e.city))
            {
                Console.WriteLine("First Name: " + items.firstName);
                Console.WriteLine("Last Name: " + items.lastName);
                Console.WriteLine("City : " + items.city);
                Console.WriteLine("Zip : " + items.zipCode);
                Console.WriteLine("Phone Number: " + items.phoneNumber);
            }
        }
        public void SortbyZipcode()
        {
            foreach (var items in contacts.OrderBy(e => e.zipCode))
            {
                Console.WriteLine("First Name: " + items.firstName);
                Console.WriteLine("Last Name: " + items.lastName);
                Console.WriteLine("City : " + items.city);
                Console.WriteLine("Zip : " + items.zipCode);
                Console.WriteLine("Phone Number: " + items.phoneNumber);
            }
        }
        public void ReadAndWriteFile()
        {
            string filepath = @"E:\C#\AddressBookAssignmentProblem\AddressBookAssignmentProblem\NewFolder\person.txt";
            foreach(var data in contacts)
            {
                using (StreamWriter sw = File.AppendText(filepath))
                    {
                        sw.WriteLine("FirastName:" +data.firstName);
                        sw.WriteLine("LastName: "+data.lastName);
                        sw.WriteLine("City: "+data.city);
                        sw.WriteLine("Zipcode: "+data.zipCode);
                        sw.WriteLine("PhoneNmuber: "+data.phoneNumber);
                        sw.Close();
                    }
                using(StreamReader sr = File.OpenText(filepath))
                {
                    string s=" ";
                    while((s=sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
        }
        public void ReadAndWriteCSVFile()
        {
            string exportfilepath = @"E:\C#\AddressBookAssignmentProblem\AddressBookAssignmentProblem\NewFolder\contact.csv";
            string Importfilepath= @"E:\C#\AddressBookAssignmentProblem\AddressBookAssignmentProblem\NewFolder\contact.csv";
            using (var record = new StreamReader(exportfilepath))
            using(var csv = new CsvReader(record,CultureInfo.InvariantCulture))
            {
                var item = csv.GetRecords<Contact>();
                foreach(Contact contact in item)
                {
                    Console.WriteLine("FirastName:" + contact.firstName);
                    Console.WriteLine("LastName: " + contact.lastName);
                    Console.WriteLine("City: " + contact.city);
                    Console.WriteLine("Zipcode: " + contact.zipCode);
                    Console.WriteLine("PhoneNmuber: " + contact.phoneNumber);
                }
            }
            foreach (var data in contacts)
            {
                using (var writer = new StreamWriter(Importfilepath))
                using (var csvImport = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvImport.WriteRecords<Contact>(contacts);
                }
            }
        }
    }
}
