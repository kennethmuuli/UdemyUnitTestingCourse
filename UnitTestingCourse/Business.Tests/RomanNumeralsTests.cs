using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Tests
{
    [TestFixture]
    internal class RomanNumeralsTests
    {
        private RomanNumerals _rAConverter;

        [SetUp] 
        public void SetUp() 
        {
            _rAConverter = new RomanNumerals();
        }

        [TestCase("IX", 9)]
        [TestCase("MMMMMDCLXXXIX", 5689)]
        [TestCase("MMMM", 4000)]
        [TestCase("IV", 4)]
        [TestCase("MDCL", 1650)]
        public void ParseRomanToArabicNumerals(string arabicNumeral, int expectedResult)
        {
            //Arrange, see setup
            //Act
            int actualResult = _rAConverter.ParseRomanToArabicNumerals(arabicNumeral);
            //Assert
            Assert.That(expectedResult, Is.EqualTo(actualResult));

        }

    }
}
