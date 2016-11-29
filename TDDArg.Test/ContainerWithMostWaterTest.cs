using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class ContainerWithMostWaterTest
    {
        [Test]
        public void When_single_p_Then_hight()
        {
            var hight = new int[] {5};

            Assert.AreEqual(0, ContainerWithMostWater.MaxArea(hight));
        }

        [Test]
        public void When_two_p_Then_small_2()
        {
            var hight = new int[] {5, 6};

            Assert.AreEqual(5, ContainerWithMostWater.MaxArea(hight));
        }

        [Test]
        public void When_three_p_Then_max()
        {
            var hight = new int[] {2, 5, 6};

            Assert.AreEqual(5, ContainerWithMostWater.MaxArea(hight));
        }
    }
}