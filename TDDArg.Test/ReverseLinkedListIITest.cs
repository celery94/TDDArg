using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class ReverseLinkedListIITest
    {
        [Test]
        public void Given_list_When_reserse_2_4_Then_return()
        {
            var root = new ListNode(1)
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

            var result = ReverseLinkedListII.ReverseBetween(root, 2, 4);

            Assert.AreEqual(1, result.val);
            Assert.AreEqual(4, result.next.val);
        }

        [Test]
        public void Given_list_When_reserse_3_4_Then_return()
        {
            var root = new ListNode(1)
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

            var result = ReverseLinkedListII.ReverseBetween(root, 3, 4);

            Assert.AreEqual(1, result.val);
            Assert.AreEqual(2, result.next.val);
            Assert.AreEqual(4, result.next.next.val);
        }

        [Test]
        public void Given_list_When_reserse_1_1_Then_return()
        {
            var root = new ListNode(1)
            {
                
            };

            var result = ReverseLinkedListII.ReverseBetween(root, 1, 1);

            Assert.AreEqual(1, result.val);
        }
    }
}
