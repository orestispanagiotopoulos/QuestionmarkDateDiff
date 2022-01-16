using App.Model;
using App.Validation;
using NUnit.Framework;


namespace App.Test.Validation
{
    public class ValidatorTest
    {
        [Test]
        public void IsValidDate_WhenInvalidPossitiveMonth_ThenReturnFalse()
        {
            // Arrange
            var validator = new Validator();
            var date = new SimpleDate(15, 13, 2021);

            // Act
            var result = validator.IsValidDate(date);

            // Assert
            Assert.AreEqual(false, result);
        }

        [Test]
        public void IsValidDate_WhenInvalidNegativeMonth_ThenReturnFalse()
        {
            // Arrange
            var validator = new Validator();
            var date = new SimpleDate(15, -1, 2021);

            // Act
            var result = validator.IsValidDate(date);

            // Assert
            Assert.AreEqual(false, result);
        }

        [Test]
        public void IsValidDate_WhenInvalidPossitiveDay_ThenReturnFalse()
        {
            // Arrange
            var validator = new Validator();
            var date = new SimpleDate(32, 12, 2021);

            // Act
            var result = validator.IsValidDate(date);

            // Assert
            Assert.AreEqual(false, result);
        }

        [Test]
        public void IsValidDate_WhenInvalidNegativeDay_ThenReturnFalse()
        {
            // Arrange
            var validator = new Validator();
            var date = new SimpleDate(-1, 12, 2021);

            // Act
            var result = validator.IsValidDate(date);

            // Assert
            Assert.AreEqual(false, result);
        }
    }
}
