namespace AddressBookAssignmentProblem
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
                Console.WriteLine("Enter number: \n 1. create new person \n 2. Display Data \n 3. Edit person Data  \n 4. Delete Person Data");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        PersonDetials.AddPerson();
                        break;
                    case 2:
                        PersonDetials.listPerson();
                        break;
                    case 3:
                        PersonDetials.EditPerson();
                        break;
                    case 4:
                        PersonDetials.DeleteContact();
                        break;
                }
            }
        }
    }
}
