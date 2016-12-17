using System;
namespace TDDArg
{
	public class MaximumSubarray
	{
		public static int MaxSubArray(int[] nums)
		{
			int maxValue = int.MinValue;

			for (int i = 0; i < nums.Length; i++)
			{
				for (int j = i; j < nums.Length; j++)
				{
					var sum = 0;
					for (int k = i; k <= j; k++)
					{
						sum += nums[k];
					}

					maxValue = Math.Max(maxValue, sum);
				}
			}

			return maxValue;
		}
	}
}
