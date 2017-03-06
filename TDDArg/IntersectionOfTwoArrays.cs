using System;
using System.Collections.Generic;

namespace TDDArg
{
    public class IntersectionOfTwoArrays
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            if (nums1.Length == 0 || nums2.Length == 0) return new int[] { };

            Array.Sort(nums1);
            Array.Sort(nums2);

            var index1 = 0;
            var index2 = 0;

            List<int> result = new List<int>();

            while (index1 < nums1.Length && index2 < nums2.Length)
            {
                var num1 = nums1[index1];
                var num2 = nums2[index2];

                if (num1 == num2)
                {
                    if (result.Count == 0 || result[result.Count - 1] != num1)
                        result.Add(num1);

                    index1++;
                    index2++;
                }
                else if (num1 < num2)
                {
                    index1++;
                }
                else
                {
                    index2++;
                }
            }

            return result.ToArray();
        }
    }
}