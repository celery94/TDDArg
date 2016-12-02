using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class ValidParenthesesTest
    {
        [Test]
        public void When_only_one_pair_Then_valid()
        {
            Assert.AreEqual(true, ValidParentheses.IsValid("()"));
        }

        [Test]
        public void When_two_pair_Then_valid()
        {
            Assert.AreEqual(true, ValidParentheses.IsValid("(){}"));
        }

        [Test]
        public void When_pair_contain_in_Then_valid()
        {
            Assert.AreEqual(true, ValidParentheses.IsValid("([]){}"));
        }

        [Test]
        public void When_single_Then_invalid()
        {
            Assert.AreEqual(false, ValidParentheses.IsValid("("));
        }

        [Test]
        public void When_single_end_Then_invalid()
        {
            Assert.AreEqual(false, ValidParentheses.IsValid(")"));
        }

        [Test]
        public void When_without_end_Then_invalid()
        {
            Assert.AreEqual(false, ValidParentheses.IsValid("({)"));
        }

        [Test]
        public void When_pair_crossed_Then_invalid()
        {
            Assert.AreEqual(false, ValidParentheses.IsValid("({)}"));
        }
    }
}