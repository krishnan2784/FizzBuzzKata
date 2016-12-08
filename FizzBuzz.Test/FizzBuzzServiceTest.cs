using FizzBuzz.Services;
using NUnit.Framework;

namespace FizzBuzz.Test
{
    [TestFixture]
    public class FizzBuzzServiceTest
    {
        [Test]
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "Fizz")]
        public void Translate(int input, string expected)
        {
            var result = FizzBuzzService.Translate(input);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}