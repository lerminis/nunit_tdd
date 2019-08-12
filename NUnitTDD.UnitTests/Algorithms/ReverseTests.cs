using NUnit.Framework;
using NUnitTDD.Algorithms;

namespace NUnitTDD.UnitTests.Algorithms
{
    [TestFixture]
    public class ReverseTests
    {
        [Test]
        public void StringReversal_WhenCalled_ReturnReversedString()
        {
            var result = Reverse.StringReversal("apple");
            
            Assert.That(result, Is.EqualTo("elppa"));
        }
        
        [Test]
        [TestCase(-15, -51)]
        [TestCase(500, 5)]
        [TestCase(981, 189)]
        public void IntReversal_WhenCalled_ReturnReversedInt(int n, int expectedResult)
        {
            var result = Reverse.IntReversal(n);
            
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}