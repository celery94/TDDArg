using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class MyStackTest
    {
        [Test]
        public void Given_stack_When_no_items_Then_empty_true()
        {
            MyStack stack = new MyStack();

            Assert.IsTrue(stack.Empty());
        }

        [Test]
        public void Given_stack_When_push_item_Then_empty_false()
        {
            MyStack stack = new MyStack();
            stack.Push(1);
            Assert.IsFalse(stack.Empty());
        }

        [Test]
        public void Given_stack_pushed_When_pop_Then_return_top_item()
        {
            MyStack stack = new MyStack();
            stack.Push(1);
            stack.Push(2);

            Assert.AreEqual(2, stack.Pop());
            Assert.AreEqual(1, stack.Pop());
        }

        [Test]
        public void Given_stack_pushed_When_top_Then_return_top_item()
        {
            MyStack stack = new MyStack();
            stack.Push(1);
            stack.Push(2);

            Assert.AreEqual(2, stack.Top());
            Assert.AreEqual(2, stack.Top());
        }
    }
}