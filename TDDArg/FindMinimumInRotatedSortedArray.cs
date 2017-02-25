using System;
using NUnit.Framework;

namespace TDDArg
{
	[TestFixture]
	public class FindMinimumInRotatedSortedArray
	{
		int FindMin(int[] nums)
		{
			int start = 0;
			int end = nums.Length - 1;

			while (start < end)
			{
				int mid = (start + end) / 2;

				if (nums[mid] > nums[mid + 1])
				{
					return nums[mid + 1];
				}
				else
				{
					if (nums[start] > nums[mid])
					{
						end = mid;
					}
					else if (nums[mid] > nums[end])
					{
						start = mid;
					}
					else
					{
						return nums[start];

					}
				}
			}

			return nums[start];
		}

		[Test]
		public void Given_array_rotated_When_find_Then_return_min()
		{
			var nums = new int[] { 4, 5, 6, 7, 8, 0, 1, 2, 3 };

			Assert.AreEqual(0, FindMin(nums));
		}

		[Test]
		public void Given_array__not_rotated_When_find_Then_return_min()
		{
			var nums = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };

			Assert.AreEqual(0, FindMin(nums));
		}

	}
}
