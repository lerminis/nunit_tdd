using NUnit.Framework;
using NUnitTDD.Algorithms;

namespace NUnitTDD.UnitTests.Algorithms
{
    [TestFixture]
    public class FibonacciTests
    {
        [Test]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        [TestCase(9, 34)]
        public void GetOutput_WhenCalled_ReturnsNthEntryInFib(int number, int expectedResult)
        {
            var result = Fibonacci.GetOutput(number);
            
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}