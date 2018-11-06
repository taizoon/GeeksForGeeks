using CountNumberOfSubStringsGreaterThanX;
using NUnit.Framework;

namespace Tests.Unit
{
    [TestFixture]
    public class SubStringsGreaterThanXCounterTests
    {
        [TestCase("471", 47, 2)]
        [TestCase("2222", 97, 3)]
        [TestCase("123", 100, 1)]
        [TestCase("1051", 50, 3)]
        public void Compute_GivenStringAndValue_ComputesNumberOfSubStringGreaterThanValue(string str, int x, int expected)
        {
            // Arrange
            var sut = new SubStringsGreaterThanXCounter();

            // Act
            var actual = sut.Count(str, x);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
