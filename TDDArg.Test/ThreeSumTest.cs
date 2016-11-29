using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class ThreeSumTest
    {
        [Test]
        public void ThreeSum_Test()
        {
            int[] nums = new[] { -1, 0, 1, 2, -1, -4 };

            var result = new List<List<int>>()
            {
                new List<int>() {-1,-1, 2},
                new List<int>() {-1, 0, 1}
            };

            Assert.AreEqual(result, ThreeSum.ThreeSumFunc(nums));
        }

        [Test]
        public void ThreeSum_four_zero()
        {
            int[] nums = new[] { 0, 0, 0, 0 };

            var result = new List<List<int>>()
            {
                new List<int>() {0,0,0},
            };

            Assert.AreEqual(result, ThreeSum.ThreeSumFunc(nums));
        }
    }
}