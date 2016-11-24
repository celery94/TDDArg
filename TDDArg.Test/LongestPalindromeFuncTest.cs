using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class LongestPalindromeFuncTest
    {
        [Test]
        public void LongestPalindrome_Even_Result()
        {
            var input = "babad";

            var ret = LongestPalindrome.LongestPalindromeFunc(input);

            Assert.AreEqual("bab", ret);
        }

        [Test]
        public void LongestPalindrome_Even_Result_Single()
        {
            var input = "a";

            var ret = LongestPalindrome.LongestPalindromeFunc(input);

            Assert.AreEqual("a", ret);
        }

        [Test]
        public void LongestPalindrome_Even_Result_M()
        {
            var input = "aaa";

            var ret = LongestPalindrome.LongestPalindromeFunc(input);

            Assert.AreEqual("aaa", ret);
        }

        [Test]
        public void LongestPalindrome_Even_Result_MM()
        {
            var input = "aaaa";

            var ret = LongestPalindrome.LongestPalindromeFunc(input);

            Assert.AreEqual("aaaa", ret);
        }

        [Test]
        public void LongestPalindrome_Odd_Result_Single()
        {
            var input = "aa";

            var ret = LongestPalindrome.LongestPalindromeFunc(input);

            Assert.AreEqual("aa", ret);
        }

        [Test]
        public void LongestPalindrome_Odd_Result()
        {
            var input = "cbbd";

            var ret = LongestPalindrome.LongestPalindromeFunc(input);

            Assert.AreEqual("bb", ret);
        }
    }
}