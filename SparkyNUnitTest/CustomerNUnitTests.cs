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
            Assert.Multiple(() =>
            {
                Assert.That(customer.GreetMessage, Is.EqualTo("Hello, Ben Spark"));
                Assert.That(customer.GreetMessage, Does.Contain(","));
                Assert.That(customer.GreetMessage, Does.StartWith("Hello"));
                Assert.That(customer.GreetMessage, Does.Match("Hello, [A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+"));
            });
        }

        [Test]
        public void GreetMessage_NotGreeted_ReturnNull()
        {
            //Arrange
            
            //Act
            
            //Assert
            Assert.IsNull(customer.GreetMessage);
        }

        [Test]
        public void DiscountCheck_DefaultCustomer_ReturnDiscountInRange()
        {
            //Arrange

            //Act
            int result= customer.Discount;

            //Assert
            Assert.That(result, Is.InRange(10, 25));
        }

        [Test]
        public void GreetMessage_GreetedWithoutLastName_ReturnNotNull()
        {
            //Arrange
            //Act
            customer.GreetAndCombineNames("ben", "");
            
            //
            Assert.IsNotNull(customer.GreetMessage);
            Assert.IsFalse(string.IsNullOrEmpty(customer.GreetMessage));
        }

        [Test]
        public void GreetChecker_EmptyFirstName_ThrowsException()
        {
            //Arrange
            //Act
            var exceptionDetails = Assert.Throws<ArgumentException>(() =>  customer.GreetAndCombineNames("", "Spark") );
            Assert.AreEqual("Empty First Name", exceptionDetails.Message);

            Assert.That(() => customer.GreetAndCombineNames("", "Spark"),
                Throws.ArgumentException.With.Message.EqualTo("Empty First Name"));

            Assert.Throws<ArgumentException>(() => customer.GreetAndCombineNames("", "Spark"));
            Assert.AreEqual("Empty First Name", exceptionDetails.Message);

            Assert.That(() => customer.GreetAndCombineNames("", "Spark"),
                Throws.ArgumentException);

        }

        [Test]
        public void CustomerType_CreateCustomerWithLessThan100order_ReturnBasicCustomer()
        {
            customer.orderTotal = 10;
            var result = customer.GetCustomerDetails();
            Assert.That(result, Is.TypeOf<BasicCustomer>());
        }
    }
}
