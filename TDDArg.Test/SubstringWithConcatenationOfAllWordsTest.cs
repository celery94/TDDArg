using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class SubstringWithConcatenationOfAllWordsTest
    {
        [Test]
        public void Given_string_When_find_one_word_Then_return()
        {
            var s = "barfoothefoobarman";
            string[] words = new[] { "foo" };

            var result = SubstringWithConcatenationOfAllWords.FindSubstring(s, words);

            Assert.AreEqual(new List<int> { 3, 9 }, result);
        }

        [Test]
        public void Given_string_When_find_two_word_Then_return()
        {
            var s = "barfoothefoobarman";
            string[] words = new[] { "foo", "bar" };

            var result = SubstringWithConcatenationOfAllWords.FindSubstring(s, words);

            Assert.AreEqual(new List<int> { 0, 9 }, result);
        }

        [Test]
        public void Given_string_When_find_three_word_Then_return()
        {
            var s = "barfoofoobarthefoobarman";
            string[] words = new[] { "foo", "bar", "the" };

            var result = SubstringWithConcatenationOfAllWords.FindSubstring(s, words);
            var expect = new List<int> { 6, 9, 12 };


            Assert.AreEqual(expect.Count, result.Count);
            Assert.IsTrue(expect.Any(q => result.Contains(q)));
        }

        [Test]
        public void Given_string_When_find_three_word_Then_return_0()
        {
            var s = "foothebar";
            string[] words = new[] { "foo", "bar", "the" };

            var result = SubstringWithConcatenationOfAllWords.FindSubstring(s, words);

            Assert.AreEqual(new List<int> { 0 }, result);
        }

        [Test]
        public void Given_string_When_find_4_word_duplicate_Then_return()
        {
            var s = "wordgoodgoodgoodbestword";
            string[] words = new[] { "word", "good", "best", "good" };

            var result = SubstringWithConcatenationOfAllWords.FindSubstring(s, words);

            Assert.AreEqual(new List<int> { 8 }, result);
        }
    }
}