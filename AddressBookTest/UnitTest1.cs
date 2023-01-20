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
            Assert.AreEqual(5, count);
        }
        [Test]
        public void ShouldUpdatePerson()
        {
            ContactModel model = new ContactModel();
            model.ID = 3;
            model.Address = "6th cross street";
            model.PhoneNumber = "86565434476";
            AddressBookRepository repository = new AddressBookRepository();
            int result=repository.UpdatePresoninAddressBook(model);
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
        [Test]
        public void AddpersonInDatabase()
        {
            ContactModel model = new ContactModel();
            model.FirstName = "Paul";
            model.LastName = "Pogba";
            model.Address = "24th avenue";
            model.PhoneNumber = "345432434879";
            model.EmailAddress = "paulyP6@gmail.com";
            model.City = "Turin";
            model.State = "Allainz";
            model.ZipCode = 543543;
            model.DateAdded = "20-01-2023";
            AddressBookRepository repository = new AddressBookRepository();
            int result = repository.AddPresoninAddressBook(model);
            Assert.AreEqual(1, result);
        }
    }
}