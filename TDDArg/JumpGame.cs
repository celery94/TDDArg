using System;
namespace TDDArg
{
	public class JumpGame
	{
		public static bool CanJump(int[] nums)
		{
			return Jump(0, nums);
		}

		public static bool Jump(int index, int[] nums)
		{
			if (index == nums.Length - 1) return true;

			var current = nums[index];

			if (current == 0) return false;

			for (int i = 1; i <= current; i++)
			{
				if (Jump(index + i, nums)) return true;
			}

			return false;
		}
	}
}
