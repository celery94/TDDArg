using System;
using System.Collections.Generic;
using System.Linq;

namespace TDDArg
{
	public class TreeSumII
	{
		public IList<IList<int>> ThreeSum(int[] nums)
		{
			List<IList<int>> result = new List<IList<int>>();

			Find(result, new List<int>(), nums, 0);

			return result;
		}

		private void Find(List<IList<int>> result, List<int> current, int[] nums, int index)
		{
			if (current.Sum() == 0 && current.Count == 3)
			{
				result.Add(new List<int>(current));
				return;
			}

			for (int i = index; i < nums.Length; i++)
			{
				current.Add(nums[i]);
				Find(result, current, nums, index + 1);
				current.RemoveAt(current.Count - 1);
			}
		}
	}
}
