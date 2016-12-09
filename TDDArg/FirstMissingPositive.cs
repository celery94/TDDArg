namespace TDDArg
{
    public class FirstMissingPositive
    {
        public static int FindFirstMissingPositive(int[] nums)
        {
            //0～1，1～2，2～3
            //遍历已有数组，找到当前的数，如果在int范围内（1～N），则替换到该位置
            //最后挨个检查，位置上的数不对的 就是缺的

            int i = 0;

            while (i < nums.Length)
            {
                var current = nums[i];
                if (current <= 0 || current > nums.Length || (current == i + 1))
                {
                    i++;
                }
                else if (nums[current - 1] != current)
                {
                    var temp = nums[current - 1];
                    nums[current - 1] = current;
                    nums[i] = temp;
                }
                else
                {
                    i++;
                }
            }

            for (int index = 0; index < nums.Length; index++)
            {
                if (nums[index] != index + 1)
                {
                    return index + 1;
                }
            }

            return nums.Length + 1;
        }
    }
}