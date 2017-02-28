using System;
using System.Collections.Generic;

namespace TDDArg
{
    public class LongestConsecutiveSequence
    {
        public int LongestConsecutive(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            int max = 0;

            foreach (var num in nums)
            {
                if (!dic.ContainsKey(num))
                {
                    max = Math.Max(max, FindMax(dic, num));
                }
            }

            return max;
        }

        private int FindMax(Dictionary<int, int> dic, int num)
        {
            int left = dic.ContainsKey(num - 1) ? dic[num - 1] : 0;
            int right = dic.ContainsKey(num + 1) ? dic[num + 1] : 0;

            var max = left + right + 1;
            dic[num - left] = max;
            dic[num + right] = max;
            dic[num] = max;

            return max;
        }
    }
}