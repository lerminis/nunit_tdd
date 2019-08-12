using NUnit.Framework;
using NUnitTDD.Algorithms;

namespace NUnitTDD.UnitTests.Algorithms
{
    [TestFixture]
    public class SearchTests
    {
        private int[] _unsortedNumbers;
        private int[] _sortedNumbers;

        [SetUp]
        public void Setup()
        {
            _unsortedNumbers = new int[] {1, 23, 56, 75, 23, 2};
            _sortedNumbers = new int[] {5, 9, 12, 18, 21, 29, 34, 45, 50, 51, 55, 63, 78};
        }
        
        [Test]
        public void LinearSearch_TargetNotFound_ReturnsMinusOne()
        {
            var result = Search.LinearSearch(_unsortedNumbers, 0);
            
            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        [TestCase(1, 0)]
        [TestCase(56, 2)]
        [TestCase(2, 5)]
        public void LinearSearch_TargetFound_ReturnsIndexOfTarget(int target, int expectedResult)
        {
            var result = Search.LinearSearch(_unsortedNumbers, target);
            
            Assert.That(result, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void BinarySearch_TargetNotFound_ReturnsMinusOne()
        {
            var result = Search.BinarySearch(_sortedNumbers, 0);
            
            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        [TestCase(18, 3)]
        [TestCase(55, 10)]
        [TestCase(5, 0)]
        [TestCase(78, 12)]
        public void BinarySearch_TargetFound_ReturnsIndexOfTarget(int target, int expectedResult)
        {
            var result = Search.BinarySearch(_sortedNumbers, target);
            
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}