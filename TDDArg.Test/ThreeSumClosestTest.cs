using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class ThreeSumClosestTest
    {
        [Test]
        [Ignore("")]
        public void When_four_input_Then_2()
        {
            var nums = new int[] { -1, 2, 1, -4 };

            Assert.AreEqual(2, ThreeSumClosest.ThreeSumClosestFunc(nums, 1));
        }
    }
}