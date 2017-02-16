using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class HammingDistanceTest
    {
        [Test]
        public void Given_x_y_When_find_Then_return()
        {
            Assert.AreEqual(2, new HammingDistance().FindHammingDistance(1, 4));
        }
    }
}