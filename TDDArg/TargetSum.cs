using System;
namespace TDDArg
{
	public class TargetSum
	{
		public static int FindTargetSumWays(int[] nums, int S)
		{
			int result = 0;
			Helper(nums, 0, S, ref result);

			return result;
		}

		private static void Helper(int[] nums, int index, int target, ref int result)
		{
			if (target == 0 && index == nums.Length)
				result++;
			if (index >= nums.Length) return;

			Helper(nums, index + 1, target - nums[index], ref result);
			Helper(nums, index + 1, target + nums[index], ref result);
		}
	}
}
