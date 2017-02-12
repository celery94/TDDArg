using System;
namespace TDDArg
{
	public class MinimumSizeSubarraySum
	{
		public static int MinSubArrayLen(int s, int[] nums)
		{
			if (nums.Length == 0) return 0;

			int start = 0;
			int end = 1;

			int length = 0;
			int sum = nums[start];

			if (sum >= s) return 1;

			while (end < nums.Length)
			{
				sum += nums[end];

				if (sum >= s)
				{
					while (sum - nums[start] >= s)
					{
						sum -= nums[start++];
					}

					if (length == 0 || end - start + 1 < length)
					{
						length = end - start + 1;

					}
				}

				end++;
			}

			return length;
		}
	}
}
