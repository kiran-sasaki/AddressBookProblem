using AddressBookAssignmentProblem;

namespace AddressBookTest
{
    public class Tests
    {
        [Test]
        public void ShouldRetrieveAllPerson()
        {
            AddressBookRepository repository = new AddressBookRepository();
            int count = repository.GetPerson();
            Assert.AreEqual(6, count);
        }
        [Test]
        public void ShouldUpdatePerson()
        {
            ContactModel model = new ContactModel();
            model.ID = 3;
            model.Address = "6th cross street";
            model.PhoneNumber = "86565434476";
            AddressBookRepository repository = new AddressBookRepository();
            int result = repository.UpdatePresoninAddressBook(model);
            Assert.AreEqual(1, result);
        }
        [Test]
        public void GetpersonbyDate()
        {
            ContactModel model = new ContactModel();
            model.DateAdded = "17-01-2023";
            AddressBookRepository repository = new AddressBookRepository();
            int count = repository.GetPersonDate(model);
            Assert.AreEqual(2,count);
        }
        [Test]
        public void GetpersonbyCityName()
        {
            ContactModel model = new ContactModel();
            model.City = "Broussia";
            AddressBookRepository repository = new AddressBookRepository();
            int count = repository.GetPersonByCity(model);
            Assert.AreEqual(1, count);
        }
        //[Test]
        //public void AddpersonInDatabase()
        //{
        //    ContactModel model = new ContactModel();
        //    model.FirstName = "Paul";
        //    model.LastName = "Pogba";
        //    model.Address = "24th avenue";
        //    model.PhoneNumber = "345432434879";
        //    model.EmailAddress = "paulyP6@gmail.com";
        //    model.City = "Turin";
        //    model.State = "Allainz";
        //    model.ZipCode = 543543;
        //    model.DateAdded = "20-01-2023";
        //    AddressBookRepository repository = new AddressBookRepository();
        //    int result = repository.AddPresoninAddressBook(model);
        //    Assert.AreEqual(1, result);
        //}
        [Test]
        public void MultiplePersonAdded()
        {
            List<ContactModel> contactsList = new List<ContactModel>();
            contactsList.Add(new ContactModel {ID=7,FirstName="Lisandro",LastName="Martinez",Address="12th main street",PhoneNumber="75346787544",EmailAddress="MartinezBucther24@gmail.com",City="Amsterdam",State="Ajax",ZipCode=56543,DateAdded="28-07-2022"});
            contactsList.Add(new ContactModel {ID=8,FirstName = "Granit", LastName = "Xhaka", Address = "34th main street", PhoneNumber = "9098977422", EmailAddress = "GarniXhaka34@gmail.com", City = "Arsenal", State = "Nort London", ZipCode = 43234, DateAdded = "10-11-2022" });
            contactsList.Add(new ContactModel {ID=9,FirstName = "Darwin", LastName = "Nunez", Address = "12th  Aveneue", PhoneNumber = "78657454232", EmailAddress = "DarwinNunez21@gmail.com", City = "Anfield", State = "Liverpool", ZipCode = 98734, DateAdded = "1-12-2022" });
            contactsList.Add(new ContactModel {ID=10,FirstName = "Jamal", LastName = "Musaiala", Address = "83th cross street", PhoneNumber = "2345575854", EmailAddress = "MusiJamal10gmail.com", City = "Allainz", State = "Bayern", ZipCode = 87534, DateAdded = "20-10-2022" });
            contactsList.Add(new ContactModel {ID=11,FirstName = "Antoine", LastName = "Griezemann", Address = "12th cross street", PhoneNumber = "87978643232", EmailAddress = "GriezieeAnto7@gmail.com", City = "Madrid", State = "Wanda mertopolitano", ZipCode = 78765, DateAdded = "10-01-2022" });
            AddressBookOperations operations = new AddressBookOperations();
            DateTime startDateTime1 = DateTime.Now;
            operations.AddingPersonWithThreads(contactsList);
            DateTime stopDateTime1 = DateTime.Now;
            Console.WriteLine("Duration With Thread " + (stopDateTime1 - startDateTime1));
        }
    }
}