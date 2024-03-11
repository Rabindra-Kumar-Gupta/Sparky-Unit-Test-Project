using NUnit.Framework;
namespace Sparky
{
    [TestFixture]
    public class CalculatorNUnitTests
    {
        [Test]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        { 
            //Arrange
            Calculator calc = new(); 

            //Act
            int result = calc.AddNumbers(10, 20);

            //Assert
            Assert.AreEqual(30, result);
            
        }
        [Test]
        [TestCase(11)]
        [TestCase(13)]
        public void IsOddNumber_InputEvenNumber_ReturnFalse(int a)
        {
            //Arrange
            Calculator calc = new();
            
            //Act
            bool isOdd = calc.IsOddNumber(a);
            
            //Assert
            Assert.That(isOdd,Is.EqualTo(true));
            Assert.IsTrue(isOdd);
        }

        [Test]
        [TestCase(5.4, 10.5)]//15.9
        [TestCase(5.43, 10.53)]//15.93
        [TestCase(5.49, 10.59)]//16.08
        public void AddNumbersDouble_InputTwoInt_GetCorrectAddition(double a,double b)
        {
            //Arrange
            Calculator calc = new();

            //Act
            double result = calc.AddNumbersDouble(a, b);

            //Assert
            Assert.AreEqual(15.9, result,.2);
        }
    }
}
