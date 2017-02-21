using System;
namespace TDDArg
{
	public class NumArray
	{
		private int[] sums;

		public NumArray(int[] nums)
		{
			sums = new int[nums.Length];
			for (int i = 0; i < nums.Length; i++)
			{
				if (i == 0)
					sums[i] = nums[i];
				else
					sums[i] = sums[i - 1] + nums[i];
			}
		}

		public int SumRange(int i, int j)
		{
			return i == 0 ? sums[j] : sums[j] - sums[i - 1];
		}
	}
}
