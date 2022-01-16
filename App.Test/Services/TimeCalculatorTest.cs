using App.Model;
using App.Services;
using NUnit.Framework;

namespace App.Test.Services
{
    public class TimeCalculatorTest
    {
        [Test]
        public void GetDayDifference_WhenTheTwoDatesAreSame_ThenReturnZero()
        {
            // Arrange
            var calculator = new TimeCalculator();
            var date1 = new SimpleDate(15, 12, 2021);
            var date2 = new SimpleDate(15, 12, 2021);

            // Act
            var result = calculator.GetDayDifference(date1, date2);

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void GetDayDifference_WhenNotALeapYear_ThenCorrectResult()
        {
            // Arrange
            var calculator = new TimeCalculator();
            var date1 = new SimpleDate(15, 5, 2018);
            var date2 = new SimpleDate(15, 5, 2019);

            // Act
            var result = calculator.GetDayDifference(date1, date2);

            // Assert
            Assert.AreEqual(365, result);
        }

        [Test]
        public void GetDayDifference_WhenDate1IsGreaterThanDay2_ThenCorrectResult()
        {
            // Arrange
            var calculator = new TimeCalculator();
            var date1 = new SimpleDate(15, 5, 2019);
            var date2 = new SimpleDate(15, 5, 2018);

            // Act
            var result = calculator.GetDayDifference(date1, date2);

            // Assert
            Assert.AreEqual(-365, result);
        }

        [Test]
        public void GetDayDifference_WhenLeapYear_ThenCorrectResult()
        {
            // Arrange
            var calculator = new TimeCalculator();
            var date1 = new SimpleDate(10, 1, 2016); // 2016 was a leap year
            var date2 = new SimpleDate(10, 1, 2017);

            // Act
            var result = calculator.GetDayDifference(date1, date2);

            // Assert
            Assert.AreEqual(366, result);
        }
    }
}
