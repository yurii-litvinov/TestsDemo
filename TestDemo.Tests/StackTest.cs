using NUnit.Framework;

namespace TestDemo.Tests
{
    public class StackTest
    {
        private Stack stack = new Stack();

        [SetUp]
        public void Setup()
        {
            stack = new Stack();
        }

        [Test]
        public void PopFromEmptyStackShouldNotFail()
        {
            stack.Pop();

            Assert.IsTrue(stack.IsEmpty);
        }

        [Test]
        public void PushShallWork()
        {
            stack.Push(1);

            Assert.IsFalse(stack.IsEmpty);
        }

        [Test]
        public void PushAndPopShallLeaveStackEmpty()
        {
            stack.Push(1);
            stack.Pop();

            Assert.IsTrue(stack.IsEmpty);
        }

        [Test]
        public void TwoPushesAndPopShallLeaveElementInStack()
        {
            stack.Push(1);
            stack.Push(2);
            stack.Pop();

            Assert.IsFalse(stack.IsEmpty);
        }

        [Test]
        public void PushAndPopShallGetExpectedValue()
        {
            stack.Push(1);
            var value = stack.Pop();

            Assert.AreEqual(1, value);
        }
    }
}