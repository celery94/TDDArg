using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class MinimumWindowSubstringTest
    {
        [Test]
        public void Given_str_When_find_Then_return_min()
        {
            var str = "ADOBECODEBANC";
            var target = "ABC";

            Assert.AreEqual("BANC", MinimumWindowSubstring.MinWindow(str, target));
        }

        [Test]
        public void Given_a_When_find_aa_Then_return_min()
        {
            var str = "a";
            var target = "aa";

            Assert.AreEqual("a", MinimumWindowSubstring.MinWindow(str, target));
        }
    }
}