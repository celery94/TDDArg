using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class PermutationsIITest
    {
        [Test]
        public void Given_array_When_permute_Then_return()
        {
            var nums = new int[] { 1, 1, 2, 2 };

            var result = PermutationsII.PermuteUnique(nums);

            foreach (var item in result)
            {
                Console.WriteLine(string.Join(",", item));
            }

            Assert.AreEqual(6, result.Count);
        }

        [Test]
        public void Given_array_When_permute_Then_return_2()
        {
            var nums = new int[] { 3, 3, 0, 3 };

            var result = PermutationsII.PermuteUnique(nums);

            foreach (var item in result)
            {
                Console.WriteLine(string.Join(",", item));
            }

            Assert.AreEqual(4, result.Count);
        }
    }
}
