namespace TDDArg
{
    public class SearchInsertPosition
    {
        public static int SearchInsert(int[] nums, int target)
        {
            int start = 0, end = nums.Length - 1;

            if (target <= nums[start]) return 0;
            if (target > nums[end]) return end + 1;
            if (target == nums[end]) return end;

            while (start <= end)
            {
                var mid = start + (end - start) / 2;

                if (nums[mid] < target)
                {
                    start = mid;
                }
                else if (nums[mid] > target)
                {
                    end = mid;
                }
                else
                {
                    return mid;
                }

                if (start == end - 1)
                {
                    if (nums[start] == target)
                    {
                        return start;
                    }
                    else
                    {
                        return end;
                    }
                }
            }

            return end;
        }
    }
}