using System;
namespace TDDArg
{
	public class JumpGame
	{
		public static bool CanJump(int[] nums)
		{
			int maxLocation = 0;
			for (int i = 0; i < nums.Length; i++)
			{
				if (maxLocation < i) return false; // if previous maxLocation smaller than i, meaning we cannot reach location i, thus return false.
				maxLocation = (i + nums[i]) > maxLocation ? i + nums[i] : maxLocation; // greedy:
			}
			return true;

			//I为每一个位置，挨个去检查，前面能否跳到当前位置，如果前面能跳的最远位置已经不能达到改位置，那就failed
		}
	}
}
