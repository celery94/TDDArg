using System;
using System.Collections.Generic;

namespace TDDArg
{
    public class Triangle
    {
        /// <summary>
        /// 可以反过来想，从最低层选小的值开始往上加，记录下来和之后的值，到顶部就是和最小的了
        /// </summary>
        /// <param name="triangle"></param>
        /// <returns></returns>
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            for (int i = triangle.Count - 2; i >= 0; i--)
            {
                for (int j = 0; j < triangle[i].Count; j++)
                {
                    triangle[i][j] += Math.Min(triangle[i + 1][j], triangle[i + 1][j + 1]);
                }
            }

            return triangle[0][0];
        }
    }
}