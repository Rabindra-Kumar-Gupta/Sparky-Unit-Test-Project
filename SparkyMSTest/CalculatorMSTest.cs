using Sparky;
using System.Globalization;
namespace SparkyMSTest
{
    [TestClass]
    public class CalculatorMSTest
    {
        [TestMethod]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {
            //Arrange
            Calculator calc = new();

            //Act
            int result = calc.AddNumbers(20, 10);

            //Assert
            Assert.AreEqual(30, result);
        }
    }
}