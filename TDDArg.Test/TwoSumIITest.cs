using System;
using NUnit.Framework;

namespace TDDArg.Test
{
	[TestFixture]
	public class TwoSumIITest
	{
		[Test]
		public void Given_array_When_find_sum_Then_return()
		{
			var nums = new int[] { 2, 7, 11, 15 };
			var result = TwoSumII.TwoSum(nums, 9);

			Assert.AreEqual(2, result[0]);
			Assert.AreEqual(7, result[1]);
		}
	}
}
