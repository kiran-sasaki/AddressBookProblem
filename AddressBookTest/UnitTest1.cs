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
    }
}