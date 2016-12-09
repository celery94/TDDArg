using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class CombinationSumIITest
    {
        [Test]
        public void Given_array_When_find_Then_return()
        {
            var nums = new[] { 10, 1, 2, 7, 6, 1, 5 };

            var result = CombinationSumII.CombinationSum2(nums, 8);

            Assert.AreEqual(4, result.Count);
        }
    }
}