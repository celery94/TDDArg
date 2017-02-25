using System;
using NUnit.Framework;

namespace TDDArg
{
	[TestFixture]
	public class MoreThanHalfNum
	{
		int Find(int[] nums)
		{
			int result = nums[0];
			int times = 1;

			for (int i = 1; i < nums.Length; i++)
			{
				if (times == 0)
				{
					result = nums[i];
					times++;
				}
				else
				{
					if (nums[i] == result)
					{
						times++;
					}
					else
					{
						times--;
					}
				}
			}

			return result;
		}

		[Test]
		public void Given_nums_When_find_Then_return()
		{
			var nums = new int[] { 1, 1, 1, 1, 3, 4, 2 };

			Assert.AreEqual(1, Find(nums));
		}

	}
}
