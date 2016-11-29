using System;
using System.Collections.Generic;
using System.Linq;

namespace TDDArg
{
    public class ThreeSum
    {
        public static IList<IList<int>> ThreeSumFunc(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();

            nums = nums.OrderBy(q => q).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        if (nums[i] + nums[j] + nums[k] == 0)
                        {
                            if (!result.Any(q => q[0] == nums[i] && q[1] == nums[j] && q[2] == nums[k]))
                                result.Add(new List<int>() { nums[i], nums[j], nums[k] });
                        }
                    }
                }
            }

            return result;
        }
    }
}