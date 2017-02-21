using System;
namespace TDDArg
{
	public class ContainsDuplicateII
	{
		public bool ContainsNearbyDuplicate(int[] nums, int k)
		{
			if (k == 0) return false;

			for (int i = 0; i < nums.Length; i++)
			{
				var index = i + 1;
				while (index <= i + k && index < nums.Length)
				{
					if (nums[i] == nums[index])
					{
						return true;
					}
					index++;
				}
			}

			return false;
		}
	}
}
