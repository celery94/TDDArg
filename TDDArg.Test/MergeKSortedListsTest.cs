using System.Collections.Generic;
using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class MergeKSortedListsTest
    {
        [Test]
        public void Given_2_linked_list_When_merged_Then_return()
        {
            ListNode node1 = new ListNode(1)
            {
                next = new ListNode(3)
            };
            ListNode node2 = new ListNode(2)
            {
                next = new ListNode(4)
            };

            var result = MergeKSortedLists.MergeKLists(new ListNode[] {node1, node2});

            Assert.AreEqual(1, result.val);
            Assert.AreEqual(2, result.next.val);
            Assert.AreEqual(3, result.next.next.val);
            Assert.AreEqual(4, result.next.next.next.val);
        }
    }
}