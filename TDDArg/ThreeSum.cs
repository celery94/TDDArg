using System;
using System.Collections.Generic;

namespace TDDArg
{
    public class ThreeSum
    {
        public static List<List<int>> ThreeSumFunc(int[] nums)
        {
            List<List<int>> result = new List<List<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        if (nums[i] + nums[j] + nums[k] == 0)
                        {
                            result.Add(new List<int>() { nums[i] , nums[j] , nums[k] });
                        }
                    }
                }
            }

            return result;
        }
    }
}