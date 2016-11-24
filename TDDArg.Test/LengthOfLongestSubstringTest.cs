using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class LengthOfLongestSubstringTest
    {
        [Test]
        public void LengthOfLongestSubstring_One()
        {
            Assert.AreEqual(0,LengthOfLongestSubstring.LengthOfLongestSubstringFunc(""));
            Assert.AreEqual(1,LengthOfLongestSubstring.LengthOfLongestSubstringFunc("bbb"));
            Assert.AreEqual(2,LengthOfLongestSubstring.LengthOfLongestSubstringFunc("au"));
            Assert.AreEqual(3,LengthOfLongestSubstring.LengthOfLongestSubstringFunc("abcabcbb"));
            Assert.AreEqual(3,LengthOfLongestSubstring.LengthOfLongestSubstringFunc("pwwkew"));
        }
    }
}