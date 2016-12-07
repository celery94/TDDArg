namespace TDDArg
{
    public class SearchForARange
    {
        public static int[] SearchRange(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;

            while (start <= end)
            {
                var mid = (start + end) / 2;

                if (nums[mid] == target)
                {
                    start = mid;
                    while ((start - 1) >= 0 && nums[start - 1] == target)
                    {
                        start--;
                    }

                    end = mid;
                    while ((end + 1) < nums.Length && nums[end + 1] == target)
                    {
                        end++;
                    }

                    return new[] { start, end };
                }
                else if (start == mid)
                {
                    if (nums[end] == target)
                    {
                        return new[] {end, end};
                    }
                    else
                    {
                        break;
                    }
                }
                else if (start == end)
                {
                    break;
                }
                else if (nums[mid] < target)
                {
                    start = mid;
                }
                else
                {
                    end = mid;
                }
            }

            return new[] { -1, -1 };
        }
    }
}