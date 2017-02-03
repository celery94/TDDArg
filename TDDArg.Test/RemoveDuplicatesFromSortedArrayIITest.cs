using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class RemoveDuplicatesFromSortedArrayIITest
    {
        [Test]
        public void Given_array_When_remove_Then_return_length()
        {
            var nums = new int[] { 1, 1, 1, 2, 2, 3 };

            Assert.AreEqual(5, RemoveDuplicatesFromSortedArrayII.RemoveDuplicates(nums));
            Assert.AreEqual(1, nums[0]);
            Assert.AreEqual(1, nums[1]);
            Assert.AreEqual(2, nums[2]);
            Assert.AreEqual(2, nums[3]);
            Assert.AreEqual(3, nums[4]);
        }
    }
}