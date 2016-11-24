using System;

namespace TDDArg
{
    public class FindMedianSortedArrays
    {
        public static double FindMedianSortedArraysFunc(int[] nums1, int[] nums2)
        {
            var middleIndex = (nums1.Length + nums2.Length) / 2;

            int startIndex = 0, index1 = 0, index2 = 0;
            int result = 0, preresult = 0;
            while (startIndex <= middleIndex)
            {
                if (index2 > nums2.Length - 1 || (index1 < nums1.Length && nums1[index1] <= nums2[index2]))
                {
                    preresult = result;
                    result = nums1[index1];
                    index1++;
                }
                else
                {
                    preresult = result;
                    result = nums2[index2];
                    index2++;
                }

                startIndex++;
            }
            if ((nums1.Length + nums2.Length) % 2 == 1)
                return (double) result;
            else
                return (double) (result + preresult) / 2;
        }
    }
}