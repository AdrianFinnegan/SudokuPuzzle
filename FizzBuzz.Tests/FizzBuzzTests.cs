using NUnit.Framework;

namespace FizzBuzz.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(30, "FizzBuzz")]
        [TestCase(100, "Buzz")]
        public void ProcessListReturnsMatches(int digit, string match)
        {
            //Arrange
            ParseFizzBuzz fizzParser = new ParseFizzBuzz();

            //Act
            var response = fizzParser.Process(100);

            //Assert
            Assert.AreEqual(match, response[digit]);
        }

        [TestCase(2)]
        [TestCase(11)]
        [TestCase(28)]
        [TestCase(73)]
        public void ProcessListShouldNotContainTheseValues(int digit)
        {
            //Arrange
            ParseFizzBuzz fizzParser = new ParseFizzBuzz();

            //Act
            var response = fizzParser.Process(100);

            //Assert
            Assert.IsFalse(response.ContainsKey(digit));
        }
    }
}