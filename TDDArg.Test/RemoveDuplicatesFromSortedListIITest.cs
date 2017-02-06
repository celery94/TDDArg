using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class RemoveDuplicatesFromSortedListIITest
    {
        [Test]
        public void Given_list_When_remove_Then_return()
        {
            ListNode list = new ListNode(1)
            {
                next = new ListNode(1)
                {
                    next = new ListNode(2)
                }
            };

            var result = RemoveDuplicatesFromSortedListII.DeleteDuplicates(list);

            Assert.AreEqual(2, result.val);
        }

        [Test]
        public void Given_list_head_duplicate_When_remove_Then_return()
        {
            ListNode list = new ListNode(1)
            {
                next = new ListNode(1)
                {
                    next = new ListNode(2)
                    {
                        next = new ListNode(2)
                        {
                            next = new ListNode(3)
                            {
                                next = new ListNode(4)
                            }
                        }
                    }
                }
            };

            var result = RemoveDuplicatesFromSortedListII.DeleteDuplicates(list);

            Assert.AreEqual(3, result.val);
            Assert.AreEqual(4, result.next.val);
        }

        //[Test]
        //public void Given_list_duplicate_When_remove_Then_return()
        //{
        //    ListNode list = new ListNode(1)
        //    {
        //        next = new ListNode(2)
        //        {
        //            next = new ListNode(2)
        //            {
        //                next = new ListNode(3)
        //                {
        //                    next = new ListNode(4)
        //                    {
        //                        next = new ListNode(5)
        //                    }
        //                }
        //            }
        //        }
        //    };

        //    var result = RemoveDuplicatesFromSortedListII.DeleteDuplicates(list);

        //    Assert.AreEqual(1, result.val);
        //    Assert.AreEqual(3, result.next.val);
        //}
    }
}