using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Tests
{
    [TestFixture]
    internal class FizzBuzzTests
    {
        [TestCase(1, "")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        public void Ask_Number1_ShouldReturnCorrectString(int number, string expectedString)
        {
            //Arrange
            var fB = new FizzBuzz();

            //Act
            string result = FizzBuzz.Ask(number);

            //Assert
            Assert.That(result, Is.EqualTo(expectedString));

        }
    }
}
