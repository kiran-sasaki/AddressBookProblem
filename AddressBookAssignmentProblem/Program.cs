﻿namespace AddressBookAssignmentProblem
{
    class program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome To Address Book Problem");
            //Object of persondetials class is created
            PersonDetials person = new PersonDetials();
            while (true)
            {
                Console.WriteLine("Enter number: \n 1. create new person \n 2. Display Data \n 3. Edit person Data  \n 4. Delete Person Data \n 5.Add Multiple Contacts  \n 6.Add With UniqueBookName \n 7.Display Dictionary \n 8.Search Duplicate Contacts \n 9.Sreach By CityName \n 10.View Persons By CityName \n 11.CountByCityName \n 12.SortByFirstName \n 13.SortbyCity \n 14.SortbyZipcode \n 15.ReadAndWriteFile \n 16.ReadAndWriteCsvFile \n 17.ReadJsonFile");
                Console.WriteLine("Enter the option");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        person.AddPerson();
                        break;
                    case 2:
                        person.listPerson();
                        break;
                    case 3:
                        person.EditPerson();
                        break;
                    case 4:
                        person.DeleteContact();
                        break;
                    case 5:
                        person.MultipleContacts();
                        break;
                    case 6:
                        person.NewUser();
                        break;
                    case 7:
                        person.Display();
                        break;
                    case 8:
                        person.DuplicateContact();
                        break;
                    case 9:
                        person.SearchPersonByCity();
                        break;
                    case 10:
                        person.ViewPersonsByCity();
                        break;
                    case 11:
                        person.CountPersonByCity();
                        break;
                    case 12 :
                        person.SortPersonName();
                        break;
                    case 13:
                        person.SortbyCityName();
                        break;
                    case 14:
                        person.SortbyZipcode();
                        break;
                    case 15:
                        person.ReadAndWriteFile();
                        break;
                    case 16:
                        person.ReadAndWriteCSVFile();
                        break;
                    case 17:
                        person.ReadJSONFile();
                        break;
                }
                Console.WriteLine("------------------------------");
            }
        }
    }
}
