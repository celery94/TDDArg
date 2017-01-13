using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class ClimbingStairsTest
    {
        [Test]
        public void Given_1_When_count_Then_return_1()
        {
            Assert.AreEqual(1, ClimbingStairs.ClimbStairs(1));
        }

        [Test]
        public void Given_2_When_count_Then_return_2()
        {
            Assert.AreEqual(2, ClimbingStairs.ClimbStairs(2));
        }

        [Test]
        public void Given_3_When_count_Then_return_3()
        {
            Assert.AreEqual(3, ClimbingStairs.ClimbStairs(3));
        }
    }
}