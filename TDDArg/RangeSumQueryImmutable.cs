using System;
namespace TDDArg
{
	public class NumArray
	{
		private int[] sums;
		private int[] _nums;

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

			_nums = nums;
		}

		public void Update(int i, int val)
		{
			var diff = val - _nums[i];
			for (int index = i; index < sums.Length; index++)
			{
				sums[index] += diff;
			}
			_nums[i] = val;
		}

		public int SumRange(int i, int j)
		{
			return i == 0 ? sums[j] : sums[j] - sums[i - 1];
		}
	}
}
