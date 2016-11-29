using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class PalindromeNumberTest
    {
        [Test]
        public void IsPalindrome_Single()
        {
            Assert.AreEqual(true, PalindromeNumber.IsPalindrome(5));
        }

        [Test]
        public void IsPalindrome_Two_True()
        {
            Assert.AreEqual(true, PalindromeNumber.IsPalindrome(55));
        }

        [Test]
        public void IsPalindrome_Two_False()
        {
            Assert.AreEqual(false, PalindromeNumber.IsPalindrome(15));
        }

        [Test]
        public void IsPalindrome_Three_True()
        {
            Assert.AreEqual(true, PalindromeNumber.IsPalindrome(151));
        }

        [Test]
        public void IsPalindrome_Three_False()
        {
            Assert.AreEqual(false, PalindromeNumber.IsPalindrome(156));
        }

        [Test]
        public void IsPalindrome_Four_True()
        {
            Assert.AreEqual(true, PalindromeNumber.IsPalindrome(1551));
        }

        [Test]
        public void IsPalindrome_Four_False()
        {
            Assert.AreEqual(false, PalindromeNumber.IsPalindrome(1555));
            Assert.AreEqual(false, PalindromeNumber.IsPalindrome(1561));
        }

        [Test]
        public void IsPalindrome_More()
        {
            Assert.AreEqual(true, PalindromeNumber.IsPalindrome(15651));
            Assert.AreEqual(false, PalindromeNumber.IsPalindrome(112561));
        }

        [Test]
        public void IsPalindrome_Negative()
        {
            Assert.AreEqual(false, PalindromeNumber.IsPalindrome(-10));
        }

        [Test]
        [Ignore("")]
        public void IsPalindrome_1000021()
        {
            Assert.AreEqual(false, PalindromeNumber.IsPalindrome(1000021));
        }
    }
}