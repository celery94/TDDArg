using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class SearchInsertPositionTest
    {
        [Test]
        public void Given_array_When_search_found_Then_middle()
        {
            var nums = new int[] { 1, 3, 5, 6 };

            Assert.AreEqual(2, SearchInsertPosition.SearchInsert(nums, 5));
        }

        [Test]
        public void Given_array_When_search_Then_middle()
        {
            var nums = new int[] { 1, 3, 5, 6 };

            Assert.AreEqual(1, SearchInsertPosition.SearchInsert(nums, 2));
        }

        [Test]
        public void Given_array_When_search_Then_first()
        {
            var nums = new int[] { 1, 3, 5};

            Assert.AreEqual(0, SearchInsertPosition.SearchInsert(nums, 1));
        }

        [Test]
        public void Given_single_array_When_search_Then_return()
        {
            var nums = new int[] { 1 };

            Assert.AreEqual(1, SearchInsertPosition.SearchInsert(nums, 2));
        }
        [Test]
        public void Given_array_When_search_Then_return_end()
        {
            var nums = new int[] { 1,3 };

            Assert.AreEqual(1, SearchInsertPosition.SearchInsert(nums, 3));
        }
    }
}