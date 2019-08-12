using NUnit.Framework;
using NUnitTDD.Algorithms;

namespace NUnitTDD.UnitTests.Algorithms
{
    [TestFixture]
    public class CapitalizeTests
    {
        [Test]
        [TestCase("a short sentence", "A Short Sentence")]
        [TestCase("look, it is working!", "Look, It Is Working!")]
        public void CapitalizeWords_WhenCalled_ReturnCapitalizedString(string str, string expectedResult)
        {
            var result = Capitalize.CapitalizeWords(str);
            
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void CapitalizeWords_NullArgument_ThrowArgNullException()
        {
            Assert.That(() => Capitalize.CapitalizeWords(null), Throws.ArgumentNullException);
        }
    }
}