using NUnit.Framework;
using NUnitTDD.Algorithms;

namespace NUnitTDD.UnitTests.Algorithms
{
    [TestFixture]
    public class VowelsTests
    {
        [Test]
        [TestCase("Why do you ask?", 4)]
        [TestCase("Why?", 0)]
        public void GetCount_WhenCalled_ReturnVowelCount(string str, int expectedResult)
        {
            var result = Vowels.GetCount(str);
            
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}