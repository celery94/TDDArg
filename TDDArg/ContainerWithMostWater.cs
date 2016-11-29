using System;

namespace TDDArg
{
    public class ContainerWithMostWater
    {
        /// <summary>
        /// why this solution is acceptable?
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public static int MaxArea(int[] height)
        {
            int maxArea = 0;
            if (height.Length >= 2)
            {
                int i = 0, j = height.Length - 1;
                while (i < j)
                {
                    var area = Math.Min(height[i], height[j]) * (j - i);
                    maxArea = Math.Max(maxArea, area);

                    if (height[i] < height[j])
                    {
                        i++;
                    }
                    else
                    {
                        j--;
                    }
                }
            }

            return maxArea;
        }
    }
}