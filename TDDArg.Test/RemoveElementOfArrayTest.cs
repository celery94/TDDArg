using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class RemoveElementOfArrayTest
    {
        [Test]
        public void Given_array_When_remove_element_Then_return()
        {
            var nums = new int[] {3, 2, 2, 3};

            var result = RemoveElementOfArray.RemoveElement(nums, 3);

            var expect = new int[] {2, 2};

            Assert.AreEqual(2, result);
            for (int i = 0; i < expect.Length; i++)
            {
                Assert.AreEqual(expect[i], nums[i]);
            }
        }
    }
}