using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class SortColorsTest
    {
        [Test]
        public void Given_array_When_sort_Then_return()
        {
            var array = new[] { 0, 1, 2, 0, 1, 2, 0, 1, 2 };

            SortColors.SortColorsFunc(array);

            Assert.AreEqual(new[] { 0, 0, 0, 1, 1, 1, 2, 2, 2 }, array);
        }
    }
}