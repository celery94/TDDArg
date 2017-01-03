using System;

namespace TDDArg
{
    public class MinimumPathSum
    {
        public static int MinPathSum(int[,] grid)
        {
            int minSum = Int32.MaxValue;
            FindMin(grid, 0, 0, 0, ref minSum);

            return minSum;
        }

        private static void FindMin(int[,] grid, int x, int y, int sum, ref int minSum)
        {
            sum += grid[x, y];

            if (sum > minSum) return;

            var xLength = grid.GetLength(0);
            var yLength = grid.GetLength(1);

            if (x == xLength - 1 && y == yLength - 1)
            {
                minSum = Math.Min(sum, minSum);
                return;
            }
            else if (x == xLength - 1)
            {
                FindMin(grid, x, y + 1, sum, ref minSum);
                return;
            }
            else if (y == yLength - 1)
            {
                FindMin(grid, x + 1, y, sum, ref minSum);
                return;
            }

            FindMin(grid, x + 1, y, sum, ref minSum);

            FindMin(grid, x, y + 1, sum, ref minSum);
        }
    }
}