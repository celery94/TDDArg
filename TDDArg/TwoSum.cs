using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDArg
{
    public class TwoSum
    {
        public static int[] TwoSumFunc(int[] nums, int target)
        {
            var result = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result.Add(i);
                        result.Add(j);
                    }
                }
            }

            return result.ToArray();
        }
    }
}
