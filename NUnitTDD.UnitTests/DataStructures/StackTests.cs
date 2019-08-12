using NUnit.Framework;
using NUnitTDD.DataStructures;

namespace NUnitTDD.UnitTests.DataStructures
{
    [TestFixture]
    public class StackTests
    {
        private Stack<string> _stack;

        [SetUp]
        public void Setup()
        {
            _stack = new Stack<string>();
        }

        [Test]
        public void Count_EmptyStack_ReturnZero()
        {
            Assert.That(_stack.Count, Is.EqualTo(0));
        }

        [Test]
        public void Push_ArgIsNull_ThrowArgNullException()
        {
            Assert.That(() => _stack.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Push_ArgIsValid_ObjAddedToList()
        {
            _stack.Push("10");

            Assert.That(_stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Pop_EmptyStack_ThrowInvalidOpException()
        {
            Assert.That(() => _stack.Pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void Pop_NonEmptyStack_ReturnTopOfStack()
        {
            _stack.Push("1");
            _stack.Push("2");
            _stack.Push("3");

            var result = _stack.Pop();

            Assert.That(result, Is.EqualTo("3"));
        }

        [Test]
        public void Pop_NonEmptyStack_StackLengthDecreased()
        {
            _stack.Push("1");
            _stack.Push("2");
            _stack.Push("3");
            _stack.Pop();

            Assert.That(_stack.Count, Is.EqualTo(2));
        }

        [Test]
        public void Peek_EmptyStack_ThrowInvalidOpException()
        {
            Assert.That(() => _stack.Peek(), Throws.InvalidOperationException);
        }

        [Test]
        public void Peek_NonEmptyStack_ReturnTopOfStack()
        {
            _stack.Push("1");
            _stack.Push("2");
            _stack.Push("3");

            var result = _stack.Pop();

            Assert.That(result, Is.EqualTo("3"));
        }

        [Test]
        public void Peek_NonEmptyStack_NoItems()
        {
            _stack.Push("1");
            _stack.Push("2");
            _stack.Push("3");

            _stack.Peek();

            Assert.That(_stack.Count, Is.EqualTo(3));
        }
    }
}