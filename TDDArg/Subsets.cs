using System;
using System.Collections.Generic;

namespace TDDArg
{
	public class SubsetsClass
	{
		public IList<IList<int>> Subsets(int[] nums)
		{
			List<IList<int>> result = new List<IList<int>>();
			Array.Sort(nums);

			Find(nums, 0, result, new List<int>());

			return result;
		}

		public void Find(int[] nums, int index, List<IList<int>> result, List<int> current)
		{
			result.Add(new List<int>(current));

			for (int i = index; i < nums.Length; i++)
			{
				current.Add(nums[i]);
				Find(nums, i + 1, result, current);
				current.RemoveAt(current.Count - 1);
			}
		}
	}
}
