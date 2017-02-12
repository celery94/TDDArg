using System;
using NUnit.Framework;

namespace TDDArg.Test
{
	[TestFixture]
	public class MinimumSizeSubarraySumTest
	{
		[Test]
		public void Given_nums_When_find_Then_return()
		{
			var nums = new int[] { 2, 3, 1, 2, 4, 3 };

			Assert.AreEqual(2, MinimumSizeSubarraySum.MinSubArrayLen(7, nums));
		}
	}
}
