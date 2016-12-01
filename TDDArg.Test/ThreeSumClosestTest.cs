using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class ThreeSumClosestTest
    {
        [Test]
        public void When_0_0_0_Then_0()
        {
            var nums = new int[] { 0, 0, 0 };

            Assert.AreEqual(0, ThreeSumClosest.ThreeSumClosestFunc(nums, 1));
        }

        [Test]
        public void When_four_input_Then_2()
        {
            var nums = new int[] { -1, 2, 1, -4 };

            Assert.AreEqual(2, ThreeSumClosest.ThreeSumClosestFunc(nums, 1));
        }

        [Test]
        public void When_many_input_Then_4()
        {
            var nums = new int[] { -5, -4, -1, 1, 2, 2, 3, 7, 9 };

            Assert.AreEqual(4, ThreeSumClosest.ThreeSumClosestFunc(nums, 4));
        }

        [Test]
        public void When_1_1_1_0_Then_3()
        {
            var nums = new int[] { 1, 1, 1, 0 };

            Assert.AreEqual(3, ThreeSumClosest.ThreeSumClosestFunc(nums, 100));
        }

        [Test]
        public void When_result_not_have_start_and_end_Then_82()
        {
            var nums = new int[] { 1, 2, 4, 8, 16, 32, 64, 128 };

            Assert.AreEqual(82, ThreeSumClosest.ThreeSumClosestFunc(nums, 82));
        }
    }
}