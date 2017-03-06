using System;
using System.Collections.Generic;

namespace TDDArg
{
    public class FindAllDuplicatesInAnArray
    {
        public IList<int> FindDuplicates(int[] nums)
        {
            List<int> result = new List<int>();
            foreach (var num in nums)
            {
                var index = Math.Abs(num) - 1;
                if (nums[index] < 0)
                {
                    result.Add(Math.Abs(num));
                }
                else
                {
                    nums[index] = 0 - nums[index];
                }
            }

            return result;
        }
    }
}