using System.Collections.Generic;
using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class TriangleTest
    {
        [Test]
        public void Given_triangle_When_find_Then_return()
        {
            var triangle = new List<IList<int>>
            {
                new List<int> {1},
                new List<int> {1,2},
                new List<int> {1, 2,3},
                new List<int> {1, 2,3,4},
            };

            Assert.AreEqual(4, new Triangle().MinimumTotal(triangle));
        }
    }
}