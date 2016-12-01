using System;
using System.Linq;

namespace TDDArg
{
    public class ThreeSumClosest
    {
        public static int ThreeSumClosestFunc(int[] nums, int target)
        {
            nums = nums.OrderBy(q => q).ToArray();

            int closest = nums[0] + nums[1] + nums[2];

            for (int start = 0; start < nums.Length - 2; start++)
            {
                for (int end = nums.Length - 1; end > start + 1; end--)
                {
                    int middle = start + 1;

                    while (middle < end)
                    {
                        if (nums[start] + nums[middle] + nums[end] >= target)
                        {
                            int currentCloest;

                            if (middle == start + 1)
                            {
                                currentCloest = nums[start] + nums[middle] + nums[end];
                            }
                            else
                            {
                                if (nums[start] + nums[middle] + nums[end] - target > target - (nums[start] + nums[middle - 1] + nums[end]))
                                {
                                    currentCloest = nums[start] + nums[middle - 1] + nums[end];
                                }
                                else
                                {
                                    currentCloest = nums[start] + nums[middle] + nums[end];
                                }
                            }

                            if (Math.Abs(target - closest) > Math.Abs(target - currentCloest))
                            {
                                closest = currentCloest;
                            }

                            break;
                        }
                        else
                        {
                            middle++;

                            if (middle == end)
                            {
                                if (Math.Abs(target - closest) > Math.Abs(target - (nums[start] + nums[middle - 1] + nums[end])))
                                {
                                    closest = nums[start] + nums[middle - 1] + nums[end];
                                }
                            }
                        }
                    }
                }
            }

            return closest;
        }
    }
}