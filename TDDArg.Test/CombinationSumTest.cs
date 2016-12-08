using System.Collections.Generic;
using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class CombinationSumTest
    {
        [Test]
        public void Given_array_When_find_Then_return()
        {
            var nums = new int[] { 2,3, 6, 7 };

            var expectResult = new List<List<int>>()
            {
                new List<int>() {7}
            };

            var result = CombinationSum.CombinationSumFunc(nums, 7);

            Assert.AreEqual(2, result.Count);
        }
    }
}