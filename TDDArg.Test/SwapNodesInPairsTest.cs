using System;
using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class SwapNodesInPairsTest
    {
        [Test]
        public void Given_list_node_When_swap_Then_return()
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

            var result = SwapNodesInPairs.SwapPairs(node);

            Assert.AreEqual(2, result.val);
            Assert.AreEqual(1, result.next.val);
            Assert.AreEqual(4, result.next.next.val);
            Assert.AreEqual(3, result.next.next.next.val);
        }
    }
}