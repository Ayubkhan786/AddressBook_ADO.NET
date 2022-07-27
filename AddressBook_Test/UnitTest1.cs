using AddressBook_ADO.NET;

namespace AddressBook_Test
{
    [TestClass]
    public class Address
    {
        [TestMethod]
        public void RetrieveFromDate()
        {
            AddressBook address = new AddressBook();
            var result = address.RetrieveFromDate();
            Assert.AreEqual("Priya", result);
            
        }
        [TestMethod]
        public void CountContactByCity()
        {
            AddressBook address = new AddressBook();
            var result = address.RetrieveByCity();
            Assert.AreEqual(1, result);
        }
    }
}
