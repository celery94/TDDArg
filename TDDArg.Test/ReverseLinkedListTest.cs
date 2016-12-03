using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class ReverseLinkedListTest
    {
        [Test]
        public void Given_list_When_reverse_Then_return()
        {
            ListNode node = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                    }
                }
            };

            var result = ReverseLinkedList.ReverseList(node);

            Assert.AreEqual(4, result.val);
            Assert.AreEqual(3, result.next.val);
            Assert.AreEqual(2, result.next.next.val);
            Assert.AreEqual(1, result.next.next.next.val);
        }
    }
}