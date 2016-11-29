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

            for (int start = 0; start < nums.Length - 1; start++)
            {
                if (start != 0 && nums[start] == nums[start - 1])
                {
                    continue;
                }

                int end = nums.Length - 1;

                while (end > start + 1)
                {
                    if (end != nums.Length - 1 && nums[end] == nums[end + 1])
                    {
                        end--;
                        continue;
                    }

                    int next = start + 1;
                    while (next < end)
                    {
                        if (next != start + 1 && nums[next] == nums[next - 1])
                        {
                            next++;
                            continue;
                        }

                        if (nums[start] + nums[next] + nums[end] == 0)
                        {
                            result.Add(new List<int>() { nums[start], nums[next], nums[end] });
                        }
                        next++;
                    }

                    end--;
                }
            }

            return result;
        }
    }
}