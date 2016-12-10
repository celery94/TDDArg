using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class MultiplyStringsTest
    {
        [Test]
        public void Given_two_number_one_is_zero_When_multify_Then_zero()
        {
            Assert.AreEqual("0", MultiplyStrings.Multiply("123", "0"));
        }

        [Test]
        public void Given_two_number_one_is_one_When_multify_Then_other_one()
        {
            Assert.AreEqual("123", MultiplyStrings.Multiply("123", "1"));
        }

        [Test]
        public void Given_two_number_3_5_When_multify_Then_return_15()
        {
            Assert.AreEqual("15", MultiplyStrings.Multiply("5", "3"));
        }

        [Test]
        public void Given_two_number_3_10_When_multify_Then_return_30()
        {
            Assert.AreEqual("30", MultiplyStrings.Multiply("3", "10"));
        }

        [Test]
        public void Given_two_number_When_multify_Then_return()
        {
            Assert.AreEqual("15129", MultiplyStrings.Multiply("123", "123"));
        }
    }
}