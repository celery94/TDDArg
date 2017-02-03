using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class RemoveDuplicatesFromSortedListTest
    {
        [Test]
        public void Given_list_When_remove_duplicate_Then_return()
        {
            ListNode list = new ListNode(1)
            {
                next = new ListNode(1)
                {
                    next = new ListNode(2)
                }
            };

            var result = RemoveDuplicatesFromSortedList.DeleteDuplicates(list);

            Assert.AreEqual(1, result.val);
            Assert.AreEqual(2, result.next.val);
        }
    }
}