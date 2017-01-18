namespace TDDArg
{
    public class SortColors
    {
        public static void SortColorsFunc(int[] nums)
        {
            int start = 0;
            int end = nums.Length - 1;

            int mid = 0;
            while (mid <= end)
            {
                if (nums[mid] == 0)
                {
                    var temp = nums[start];
                    nums[start] = nums[mid];
                    nums[mid] = temp;
                    start++;
                    mid++;
                }
                else if (nums[mid] == 2)
                {
                    var temp = nums[end];
                    nums[end] = nums[mid];
                    nums[mid] = temp;
                    end--;
                }
                else
                {
                    mid++;
                }
            }
        }
    }
}