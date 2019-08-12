using NUnit.Framework;
using NUnitTDD.DataStructures;

namespace NUnitTDD.UnitTests.DataStructures
{
    [TestFixture]
    public class QueueTests
    {
        private Queue<string> _queue;

        [SetUp]
        public void Setup()
        {
            _queue = new Queue<string>();
        }

        [Test]
        public void Count_EmptyQueue_ReturnZero()
        {
            Assert.That(_queue.Count, Is.EqualTo(0));
        }

        [Test]
        public void Push_ArgIsNull_ThrowArgNullException()
        {
            Assert.That(() => _queue.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Push_ArgIsValid_ObjAddedToList()
        {
            _queue.Push("10");

            Assert.That(_queue.Count, Is.EqualTo(1));
        }
        
        [Test]
        public void Remove_EmptyQueu_ThrowInvalidOpException()
        {
            Assert.That(() => _queue.Remove(), Throws.InvalidOperationException);
        }

        [Test]
        public void Remove_NonEmptyQueue_ReturnFirstObjInList()
        {
            _queue.Push("1");
            _queue.Push("2");
            _queue.Push("3");

            var result = _queue.Remove();

            Assert.That(result, Is.EqualTo("1"));
        }

        [Test]
        public void Remove_NonEmptyQueue_QueueLengthDecreased()
        {
            _queue.Push("1");
            _queue.Push("2");
            _queue.Push("3");
            _queue.Remove();

            Assert.That(_queue.Count, Is.EqualTo(2));
        }

        [Test]
        public void Peek_NonEmptyQueue_ReturnFirstObjInList()
        {
            _queue.Push("1");
            _queue.Push("2");
            _queue.Push("3");

            var result = _queue.Peek();

            Assert.That(result, Is.EqualTo("1"));
        }

        [Test]
        public void Peek_NonEmptyQueue_NoItemsRemoved()
        {
            _queue.Push("1");
            _queue.Push("2");
            _queue.Push("3");

            _queue.Peek();

            Assert.That(_queue.Count, Is.EqualTo(3));
        }

    }
}