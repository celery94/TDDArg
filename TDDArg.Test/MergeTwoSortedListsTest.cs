using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    class MergeTwoSortedListsTest
    {
        [Test]
        public void Given_one_node_list_is_empty_When_merged_Then_return_non_empty_node()
        {
            ListNode node1 = new ListNode(1);
            ListNode node2 = null;

            var node = MergeTwoSortedLists.MergeTwoLists(node1, node2);

            List<int> result = new List<int>() { 1};
            var index = 0;
            while (node != null)
            {
                Assert.IsTrue(index < result.Count);
                Assert.AreEqual(result[index], node.val);
                node = node.next;
                index++;
            }
        }

        [Test]
        public void Given_two_single_node_list_When_merged_Then_two_node()
        {
            ListNode node1 = new ListNode(1);
            ListNode node2 = new ListNode(2);

            var node = MergeTwoSortedLists.MergeTwoLists(node1, node2);

            List<int> result = new List<int>() { 1, 2 };
            var index = 0;
            while (node != null)
            {
                Assert.IsTrue(index < result.Count);
                Assert.AreEqual(result[index], node.val);
                node = node.next;
                index++;
            }
        }
    }
}
