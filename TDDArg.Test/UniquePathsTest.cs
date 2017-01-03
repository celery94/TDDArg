using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class UniquePathsTest
    {
        [Test]
        public void Given_grid_2_2_When_find_Then_return_2()
        {
            Assert.AreEqual(2, UniquePaths.FindUniquePaths(2, 2));
        }
    }
}