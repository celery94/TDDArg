using System;
using System.Collections.Generic;

namespace TDDArg
{
	public class ContainsDuplicateII
	{
		public bool ContainsNearbyDuplicate(int[] nums, int k)
		{
			if (k == 0) return false;

			Dictionary<int, int> dic = new Dictionary<int, int>();

			for (int i = 0; i < nums.Length; i++)
			{
				var num = nums[i];
				if (dic.ContainsKey(num))
				{
					var diff = i - dic[num];
					if (diff <= k)
						return true;
					else
						dic[num] = i;
				}
				else
				{
					dic.Add(num, i);
				}
			}

			return false;
		}
	}
}
