using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class RemoveNthNodeFromEndOfListTest
    {
        [Test]
        public void Given_5_linked_node_When_remove_2th_from_end_of_List_Then_2th_from_end_removed()
        {
            ListNode node = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                        {
                            next = new ListNode(5)
                        }
                    }
                }
            };

            var result = RemoveNthNodeFromEndOfList.RemoveNthFromEnd(node, 2);


            while (result != null)
            {
                Assert.AreNotEqual(4, result.val);
                result = result.next;
            }
        }

        [Test]
        public void Given_1_linked_node_When_remove_1th_from_end_of_List_Then_empty()
        {
            ListNode node = new ListNode(1)
            {

            };

            var result = RemoveNthNodeFromEndOfList.RemoveNthFromEnd(node, 1);

            Assert.AreEqual(null, result);
        }
    }
}