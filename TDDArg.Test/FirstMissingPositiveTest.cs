using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class FirstMissingPositiveTest
    {
        [Test]
        public void Given_array_When_find_Then_return()
        {
            Assert.AreEqual(1, FirstMissingPositive.FindFirstMissingPositive(new int[] { }));
            Assert.AreEqual(2, FirstMissingPositive.FindFirstMissingPositive(new int[] { 1 }));
            Assert.AreEqual(2, FirstMissingPositive.FindFirstMissingPositive(new int[] { 1, 1 }));
            Assert.AreEqual(3, FirstMissingPositive.FindFirstMissingPositive(new int[] { 1, 2, 0 }));
            Assert.AreEqual(2, FirstMissingPositive.FindFirstMissingPositive(new int[] { 3, 4, -1, 1 }));
        }
    }
}