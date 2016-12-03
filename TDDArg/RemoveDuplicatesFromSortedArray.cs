using System.Linq;

namespace TDDArg
{
    public class RemoveDuplicatesFromSortedArray
    {
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length <= 1) return nums.Length;

            int index = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[index])
                {
                    index++;
                    nums[index] = nums[i];
                }
            }

            return index + 1;
        }
    }
}