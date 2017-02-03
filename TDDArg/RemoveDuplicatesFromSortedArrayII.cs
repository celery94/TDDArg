namespace TDDArg
{
    public class RemoveDuplicatesFromSortedArrayII
    {
        public static int RemoveDuplicates(int[] nums)
        {
            bool isDuplicate = false;

            var count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    count++;
                }
                else
                {
                    if (nums[i - 1] == nums[i])
                    {
                        if (isDuplicate == false)
                        {
                            nums[count++] = nums[i];
                            isDuplicate = true;
                        }
                    }
                    else
                    {
                        isDuplicate = false;
                        nums[count++] = nums[i];
                    }
                }
            }

            return count;
        }
    }
}