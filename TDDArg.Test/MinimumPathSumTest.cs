using System.Configuration;
using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class MinimumPathSumTest
    {
        [Test]
        public void Given_grid_When_find_min_Then_return()
        {
            var grid = new int[2, 3];

            grid[0, 0] = 1;
            grid[0, 1] = 2;
            grid[0, 2] = 3;
            grid[1, 0] = 4;
            grid[1, 1] = 5;
            grid[1, 2] = 6;

            Assert.AreEqual(12, MinimumPathSum.MinPathSum(grid));
        }

        [Test]
        public void Given_grid_1_1_When_find_min_Then_return()
        {
            var grid = new int[1, 1];

            grid[0, 0] = 1;

            Assert.AreEqual(1, MinimumPathSum.MinPathSum(grid));
        }
    }
}