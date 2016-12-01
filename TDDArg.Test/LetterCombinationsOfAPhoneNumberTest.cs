using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class LetterCombinationsOfAPhoneNumberTest
    {
        [Test]
        public void When_Single_word_Then_char_array()
        {
            Assert.AreEqual(new List<string>() { "a", "b", "c" }, LetterCombinationsOfAPhoneNumber.LetterCombinations("2"));
        }

        [Test]
        public void When_23_Then_combination_array()
        {
            var expect = new List<string>() {"ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"};
            var result = LetterCombinationsOfAPhoneNumber.LetterCombinations("23");

            Assert.IsTrue(expect.Count==result.Count);
            Assert.IsTrue(expect.Any(q=>result.Contains(q)));
        }
    }
}