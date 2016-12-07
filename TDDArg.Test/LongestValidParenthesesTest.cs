using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class LongestValidParenthesesTest
    {
        [Test]
        public void Given_three_When_find_Then_return_2()
        {
            Assert.AreEqual(2, LongestValidParentheses.FindLongestValidParentheses("(()"));
        }

        [Test]
        public void Given_6_When_find_Then_return_4()
        {
            Assert.AreEqual(4, LongestValidParentheses.FindLongestValidParentheses(")()())"));
        }

        [Test]
        public void Given_only_start_When_find_Then_return_0()
        {
            Assert.AreEqual(0, LongestValidParentheses.FindLongestValidParentheses("((((((((((((((((((((((((("));
        }
    }
}