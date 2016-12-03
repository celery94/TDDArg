using System.Collections.Generic;
using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class GenerateParenthesesTest
    {
        [Test]
        public void Given_number_1_When_gen_Then_one_result()
        {
            Assert.AreEqual(new List<string> {"()"}, GenerateParentheses.GenerateParenthesis(1));
        }

        [Test]
        public void Given_number_2_When_gen_Then_two_result()
        {
            var expect = new List<string>()
            {
                "()()",
                "(())"
            };

            var result = GenerateParentheses.GenerateParenthesis(2);
            Assert.AreEqual(expect.Count, result.Count);
        }
    }
}