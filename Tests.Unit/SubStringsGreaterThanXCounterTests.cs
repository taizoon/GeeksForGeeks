using CountNumberOfSubStringsGreaterThanX;
using NUnit.Framework;

namespace Tests.Unit
{
    [TestFixture]
    public class SubStringsGreaterThanXCounterTests
    {
        [TestCase("471", 47, ExpectedResult = 2)]
        [TestCase("2222", 97, ExpectedResult = 3)]
        [TestCase("123", 100, ExpectedResult = 1)]
        [TestCase("1051", 50, ExpectedResult = 3)]
        public int Compute_GivenStringAndValue_ComputesNumberOfSubStringGreaterThanValue(string str, int x)
        {
            // Arrange
            var sut = new SubStringsGreaterThanXCounter();

            // Act
            return sut.Count(str, x);
        }
    }
}
