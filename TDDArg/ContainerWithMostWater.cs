using System;

namespace TDDArg
{
    public class ContainerWithMostWater
    {
        public static int MaxArea(int[] height)
        {
            int maxArea = 0;
            if (height.Length >= 2)
            {
                for (int i = 0; i < height.Length - 1; i++)
                {
                    for (int j = i + 1; j < height.Length; j++)
                    {
                        var area = Math.Min(height[i], height[j]) * (j - i);
                        maxArea = Math.Max(maxArea, area);
                    }
                }
            }

            return maxArea;
        }
    }
}