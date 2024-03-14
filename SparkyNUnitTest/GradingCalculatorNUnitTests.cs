using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky
{
    [TestFixture]
    public class GradingCalculatorNUnitTests
    {
        private GradingCalculator gCalc;
        [SetUp]
        public void SetUp()
        {
            gCalc = new GradingCalculator();
        }

        [Test]
        public void CheckGrade_Score95_Attendance90_ReturnGradeA()
        {
            //arrange
            // Arrange initialization has been done globlaly in SetUp method
            //Act
            gCalc.Score = 95;
            gCalc.AttendancePercentage = 92;
            var result = gCalc.GetGrade();
            //Assert
            Assert.That(result, Is.EqualTo("A"));
        }
        
        [Test]
        public void CheckGrade_Score85_Attendance90_ReturnGradeB()
        {
            //arrange
            // Arrange initialization has been done globlaly in SetUp method
            //Act
            gCalc.Score = 85;
            gCalc.AttendancePercentage = 90;
            var result = gCalc.GetGrade();
            //Assert
            Assert.That(result, Is.EqualTo("B"));
        }
        
        [Test] 
        public void CheckGrade_Score65_Attendance90_ReturnGradeC()
        {
            //arrange
            // Arrange initialization has been done globlaly in SetUp method
            //Act
            gCalc.Score = 65;
            gCalc.AttendancePercentage = 90;
            var result = gCalc.GetGrade();
            //Assert
            Assert.That(result, Is.EqualTo("C"));
        }

        [Test]
        public void CheckGrade_Score95_Attendance65_ReturnGradeB()
        {
            //arrange
            // Arrange initialization has been done globlaly in SetUp method
            //Act
            gCalc.Score = 95;
            gCalc.AttendancePercentage = 65;
            var result = gCalc.GetGrade();
            //Assert
            Assert.That(result, Is.EqualTo("B"));
        }

        [Test]
        [TestCase(95,55)]
        [TestCase(65,55)]
        [TestCase(50,90)]
        public void GradeCalc_FailureScenarios_GetFGrade(int score, int grade)
        {
            //Arrange
            //Act
            gCalc.Score = score;
            gCalc.AttendancePercentage = grade;
            var result = gCalc.GetGrade();
            //Assert
            Assert.That(result, Is.EqualTo("F"));

        }

        [Test]
        [TestCase(95, 90, ExpectedResult = "A")]
        [TestCase(85, 90, ExpectedResult = "B")]
        [TestCase(65, 90, ExpectedResult = "C")]
        [TestCase(95, 65, ExpectedResult = "B")]
        [TestCase(95, 55, ExpectedResult = "F")]
        [TestCase(65, 55, ExpectedResult = "F")]
        [TestCase(50, 90, ExpectedResult = "F")]
        public string GradeCalc_AllGradeLogicalScenarios_GradeOutput(int score, int grade)
        {
            //Arrange
            //Act
            gCalc.Score = score;
            gCalc.AttendancePercentage = grade;
            return gCalc.GetGrade();
        }
    }
}
