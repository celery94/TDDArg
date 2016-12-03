using System.Collections.Generic;
using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class ReverseNodesInKGroupTest
    {
        private ListNode _node = null;

        [SetUp]
        public void Prepare()
        {
            _node = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                        {
                            next = new ListNode(5)
                            {
                                next = new ListNode(6)
                            }
                        }
                    }
                }
            };
        }

        [Test]
        public void Given_6_node_list_When_k_is_6_Then_return()
        {
            var result = ReverseNodesInKGroup.ReverseKGroup(_node, 6);

            var vals = new Queue<int>(new[] {6, 5, 4, 3, 2, 1});

            while (result != null)
            {
                Assert.AreEqual(vals.Dequeue(), result.val);
                result = result.next;
            }
        }

        [Test]
        public void Given_6_node_list_When_k_is_3_Then_return()
        {
            var result = ReverseNodesInKGroup.ReverseKGroup(_node, 3);

            var vals = new Queue<int>(new[] {3, 2, 1, 6, 5, 4});

            while (result != null)
            {
                Assert.AreEqual(vals.Dequeue(), result.val);
                result = result.next;
            }
        }

        [Test]
        public void Given_6_node_list_When_k_is_4_Then_return()
        {
            var result = ReverseNodesInKGroup.ReverseKGroup(_node, 4);

            var vals = new Queue<int>(new[] {4, 3, 2, 1, 5, 6});

            while (result != null)
            {
                Assert.AreEqual(vals.Dequeue(), result.val);
                result = result.next;
            }
        }
    }
}