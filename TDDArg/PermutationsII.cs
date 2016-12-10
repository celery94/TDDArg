using System;
using System.Collections.Generic;
using System.Linq;

namespace TDDArg
{
	public class PermutationsII
	{
		public static IList<IList<int>> PermuteUnique(int[] nums)
		{
			nums = nums.OrderBy(q => q).ToArray();

			List<IList<int>> result = new List<IList<int>>();

			Find(result, nums, new List<int> {  });

			return result;
		}

		static void Find(List<IList<int>> result, int[] nums, List<int> currentList)
		{
			if (currentList.Count == nums.Length)
			{
				result.Add(currentList.Select(q => nums[q]).ToList());
				return;
			}

			int? pre = null;
			for (int i = 0; i < nums.Length; i++)
			{
				if (!currentList.Contains(i))
				{
					var item = nums[i];

					if (pre == null) pre = item;
					else if (pre == item) continue;

					currentList.Add(i);
					Find(result, nums, currentList);
					currentList.RemoveAt(currentList.Count - 1);
				}
			}
		}
	}
}
