using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class SearchForARangeTest
    {
        [Test]
        public void Given_array_When_search_Then_return()
        {
            var nums = new int[] { 5, 7, 7, 8, 8, 10 };

            Assert.AreEqual(new[] { 3, 4 }, SearchForARange.SearchRange(nums, 8));
        }

        [Test]
        public void Given_single_array_When_search_Then_return()
        {
            var nums = new int[] { 1 };

            Assert.AreEqual(new[] { 0, 0 }, SearchForARange.SearchRange(nums, 1));
        }

        [Test]
        public void Given_single_array_When_search_0_Then_return()
        {
            var nums = new int[] { 1 };

            Assert.AreEqual(new[] { -1, -1 }, SearchForARange.SearchRange(nums, 0));
        }

        [Test]
        public void Given_array_2_When_search_1_Then_return()
        {
            var nums = new int[] { 2, 2 };

            Assert.AreEqual(new[] { -1, -1 }, SearchForARange.SearchRange(nums, 3));
        }

        [Test]
        public void Given_array_2_When_search_end_Then_return()
        {
            var nums = new int[] { 1, 4 };

            Assert.AreEqual(new[] { 1, 1 }, SearchForARange.SearchRange(nums, 4));
        }
    }
}