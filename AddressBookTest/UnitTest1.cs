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
    }
}