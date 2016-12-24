using System;
using NUnit.Framework;

namespace TDDArg.Test
{
	[TestFixture]
	public class JumpGameTest
	{
		[Test]
		public void Given_array_When_find_Then_return()
		{
			var nums = new int[] { 3, 2, 1, 4 };

			var ret = JumpGame.CanJump(nums);

			Assert.IsTrue(ret);
		}

		[Test]
		public void Given_array_When_find_Then_return_false()
		{
			var nums = new int[] { 3, 2, 1, 0, 4 };

			var ret = JumpGame.CanJump(nums);

			Assert.IsFalse(ret);
		}
	}
}
