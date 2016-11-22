using System;
using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class TwoSumTest
    {
        [Test]
        public void TwoSum_One()
        {
            int[] nums = new int[] { 2, 7 };
            Assert.AreEqual(new int[] { 0, 1 }, TwoSum.TwoSumFunc(nums, 9));
        }

        [Test]
        public void TwoSum_Two()
        {
            int[] nums = new int[] { 2, 7, 1 };
            Assert.AreEqual(new int[] { 0, 2 }, TwoSum.TwoSumFunc(nums, 3));
        }
    }
}
