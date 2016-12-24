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
		}
	}
}
