using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class RemoveDuplicatesFromSortedArrayTest
    {
        [Test]
        public void Given_array_When_remove_duplicate_Then_return()
        {
            var array = new int[] {1, 1, 2};

            var expect = new int[] {1, 2, 0};

            var count = RemoveDuplicatesFromSortedArray.RemoveDuplicates(array);

            Assert.AreEqual(2, count);
            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual(expect[i], array[i]);
            }
        }
    }
}