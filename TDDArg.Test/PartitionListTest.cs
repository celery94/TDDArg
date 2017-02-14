using NUnit.Framework;
using NUnit.Framework.Internal;

namespace TDDArg.Test
{
    [TestFixture]
    public class PartitionListTest
    {
        [Test]
        public void Given_list_When_partition_3_Then_return()
        {
            var list = new ListNode(5)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                    },
                }
            };

            var result = PartitionList.Partition(list, 3);

            Assert.AreEqual(2, result.val);
        }

        [Test]
        public void Given_list_When_partition_2_Then_return()
        {
            var list = new ListNode(2)
            {
                next = new ListNode(1)
                {
                }
            };

            var result = PartitionList.Partition(list, 2);

            Assert.AreEqual(1, result.val);
        }
    }
}