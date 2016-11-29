using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class LongestCommonPrefixTest
    {
        [Test]
        public void When_empty_Then_whole_word()
        {
            Assert.AreEqual(string.Empty, LongestCommonPrefix.LongestCommonPrefixFunc(new string[] { }));
        }

        [Test]
        public void When_single_Then_whole_word()
        {
            Assert.AreEqual("abcgd", LongestCommonPrefix.LongestCommonPrefixFunc(new[] { "abcgd" }));
        }

        [Test]
        public void When_tow_Then_same_prefix()
        {
            Assert.AreEqual("ab", LongestCommonPrefix.LongestCommonPrefixFunc(new[] { "abcgd", "absadfsdaf" }));
        }
    }
}