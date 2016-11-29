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

        [Test]
        public void RegularExpressionMatching_with_star_match_empty_true()
        {
            Assert.AreEqual(true, RegularExpressionMatching.IsMatch("ac", "a*c"));
            Assert.AreEqual(true, RegularExpressionMatching.IsMatch("acv", "a*c*v"));
        }

        [Test]
        [Ignore("")]
        public void RegularExpressionMatching_with_star_match_duplicate_true()
        {
            Assert.AreEqual(true, RegularExpressionMatching.IsMatch("acdc", "a*c"));
        }

        [Test]
        public void RegularExpressionMatching_with_star_false()
        {
            Assert.AreEqual(false, RegularExpressionMatching.IsMatch("a", "ab*"));
        }

        [Test]
        public void RegularExpressionMatching_with_star_false_long()
        {
            Assert.AreEqual(false, RegularExpressionMatching.IsMatch("ab", "ab*c"));
        }
    }
}