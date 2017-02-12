using System;
using System.Linq;

namespace TDDArg
{
	public class PartitionEqualSubsetSum
	{
		public static bool CanPartition(int[] nums)
		{
			var sum = nums.ToList().Sum();
			if (sum % 2 == 1) return false;

			return Helper(nums.OrderBy(q => q).ToArray(), 0, sum / 2);
		}

		private static bool Helper(int[] nums, int index, int target)
		{
			if (target == 0) return true;
			if (target < 0) return false;

			for (int i = index; i < nums.Length; i++)
			{
				if (Helper(nums, i + 1, target - nums[i])) return true;
			}

			return false;
		}
	}
}
