using System;
using NUnit.Framework;

namespace TDDArg.Test
{
	[TestFixture]
	public class MaximumSubarrayTest
	{
		[Test]
		public void Given_array_When_find_Then_return()
		{
			var nums = new int[] {-2, 1, -3, 4, -1, 2, 1, -5, 4 };

			Assert.AreEqual(6, MaximumSubarray.MaxSubArray(nums));
		}
	}
}
