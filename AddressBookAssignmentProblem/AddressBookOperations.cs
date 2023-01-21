using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookAssignmentProblem
{

    public class AddressBookOperations
    {
        public List<ContactModel> contactList = new List<ContactModel>();
        public void AddingPersonWithThreads(List<ContactModel> contactList)
        {
            contactList.ForEach(data =>
            {
                Task thread = new Task(() =>
                {
                    Console.WriteLine("Person Being Added" + data.FirstName);
                    this.AddPeronsContacts(data);
                    Console.WriteLine("Person Added" + data.FirstName);
                });
                thread.Start();
            });
        }
        public void AddPeronsContacts(ContactModel model)
        {
            contactList.Add(model);
        }
    }
}
