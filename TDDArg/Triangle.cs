using System;
using System.Collections.Generic;

namespace TDDArg
{
    public class Triangle
    {
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            return FindMin(triangle, 0, 0);
        }

        private int FindMin(IList<IList<int>> triangle, int level, int index)
        {
            if (triangle.Count <= level) return 0;

            var list = triangle[level];

            return list[index] + Math.Min(FindMin(triangle, level + 1, index), FindMin(triangle, level + 1, index + 1));
        }
    }
}