using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class RegularExpressionMatchingTest
    {
        [Test]
        public void RegularExpressionMatching_without_dot_start_true()
        {
            Assert.AreEqual(true, RegularExpressionMatching.IsMatch("aa", "aa"));
        }

        [Test]
        public void RegularExpressionMatching_without_dot_start_false()
        {
            Assert.AreEqual(false, RegularExpressionMatching.IsMatch("aa", "a"));
            Assert.AreEqual(false, RegularExpressionMatching.IsMatch("aaa", "aa"));
        }

        [Test]
        public void RegularExpressionMatching_with_dot_true()
        {
            Assert.AreEqual(true, RegularExpressionMatching.IsMatch("aa", "a."));
            Assert.AreEqual(true, RegularExpressionMatching.IsMatch("aa", ".a"));
            Assert.AreEqual(true, RegularExpressionMatching.IsMatch("baa", "b.a"));
        }

        [Test]
        public void RegularExpressionMatching_with_dot_false()
        {
            Assert.AreEqual(false, RegularExpressionMatching.IsMatch("aab", "a.c"));
            Assert.AreEqual(false, RegularExpressionMatching.IsMatch("aaa", ".a"));
        }

        [Test]
        public void RegularExpressionMatching_with_star_true()
        {
            Assert.AreEqual(true, RegularExpressionMatching.IsMatch("aac", "a*c"));
            Assert.AreEqual(true, RegularExpressionMatching.IsMatch("aaaaac", "a*c"));
        }

    }
}