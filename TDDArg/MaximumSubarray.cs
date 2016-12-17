using System;
namespace TDDArg
{
	public class MaximumSubarray
	{
		public static int MaxSubArray(int[] nums)
		{
			//如果当前数组加上当前数的值比数组本身的值还要小，那就需要reset了

			int maxValue = nums[0];
			int currentMaxValue = nums[0];

			for (int i = 1; i < nums.Length; i++)
			{
				if (currentMaxValue + nums[i] < nums[i])
				{
					currentMaxValue = nums[i];
				}
				else
				{
					currentMaxValue += nums[i];
				}

				maxValue = Math.Max(maxValue, currentMaxValue);
			}

			return maxValue;
		}
	}
}
