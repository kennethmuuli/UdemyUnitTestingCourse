using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Business;

namespace Business.Tests
{
    [TestFixture]
    internal class DegreeConverterTests
    {

        [Test]
        public void ToFahrenheit_Double0_ReturnsDouble32()
        {
            // Arrange
            var dConverter = new DegreeConverter();

            // Act
            double result = dConverter.ToFahrenheit(0);

            // Assert
            Assert.That(result, Is.EqualTo(32));
        }

        [Test]
        public void ToCelsius_Double1_ReturnsDouble0()
        {
            // Arrange
            var dConverter = new DegreeConverter();

            // Act
            double result = dConverter.ToCelsius(1);

            // Assert
            Assert.That(result, Is.EqualTo(0));

        }
    }
}
