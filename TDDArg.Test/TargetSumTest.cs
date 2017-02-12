using System;
using NUnit.Framework;

namespace TDDArg.Test
{
	[TestFixture]
	public class TargetSumTest
	{
		[Test]
		public void Given_array_When_find_Then_return()
		{
			var nums = new int[] { 1, 1, 1, 1, 1 };

			Assert.AreEqual(5, TargetSum.FindTargetSumWays(nums, 3));
		}
	}
}
