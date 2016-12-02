using System.Collections.Generic;
using System.Linq;

namespace TDDArg
{
    public class FourSum
    {
        public static IList<IList<int>> FourSumFunc(int[] nums, int target)
        {
            if (nums.Length == 0) return new List<IList<int>>();

            nums = nums.OrderBy(q => q).ToArray();

            int max = nums[nums.Length - 1];

            List<IList<int>> result = new List<IList<int>>();

            for (int start = 0; start < nums.Length - 2; start++)
            {
                if (start != 0 && nums[start] == nums[start - 1])
                    continue;
                if (nums[start] + 3 * max < target)
                    continue;
                if (nums[start] * 4 > target)
                    break;

                for (int end = nums.Length - 1; end > start + 2; end--)
                {
                    if (end != nums.Length - 1 && nums[end] == nums[end + 1])
                        continue;
                    if (nums[end] + 3 * max < target)
                        continue;

                    for (int mid1 = start + 1; mid1 < end; mid1++)
                    {
                        if (mid1 != start + 1 && nums[mid1] == nums[mid1 - 1])
                            continue;
                        if (nums[mid1] + 3 * max < target)
                            continue;
                        if (nums[mid1] * 3 + nums[start] > target)
                            break;

                        int mid2 = end - 1;
                        while (mid2 > mid1)
                        {
                            if (mid2 != end - 1 && nums[mid2] == nums[mid2 + 1])
                            {
                                mid2--;
                                continue;
                            }
                            if (nums[mid2] + 3 * max < target)
                            {
                                mid2--;
                                continue;
                            }
                            if (nums[mid2] * 2 + nums[start] + nums[mid1] > target)
                            {
                                mid2--;
                                continue;
                            }

                            if (nums[start] + nums[mid1] + nums[mid2] + nums[end] == target)
                            {
                                var item = new List<int> { nums[start], nums[mid1], nums[mid2], nums[end] };

                                result.Add(item);
                            }

                            mid2--;
                        }

                    }
                }
            }

            return result;
        }
    }
}