using NUnit.Framework;

namespace Sparky
{
    [TestFixture]
    public class CustomerNUnitTests
    {
        private Customer? customer;
        [SetUp]
        public void SetUp()
        {
            customer = new Customer();
        }

        [Test]
        public void CombineNames_InputFirstAndLastName_ReturnFullName()
        {
            //Arrange
            
            //Act
            string fullName = customer.GreetAndCombineNames("Ben", "Spark");
            //Assert
            Assert.That(customer.GreetMessage, Is.EqualTo("Hello, Ben Spark"));
            Assert.That(customer.GreetMessage, Does.Contain(","));
            Assert.That(customer.GreetMessage, Does.StartWith("Hello"));
        }

        [Test]
        public void GreetMessage_NotGreeted_ReturnNull()
        {
            //Arrange
            
            //Act
            
            //Assert
            Assert.IsNull(customer.GreetMessage);
        }

    }
}
