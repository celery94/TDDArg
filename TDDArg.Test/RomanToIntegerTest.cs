using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class RomanToIntegerTest
    {
        [Test]
        public void When_I_Then_1()
        {
            Assert.AreEqual(1, RomanToInteger.RomanToInt("I"));
        }

        [Test]
        public void When_II_Then_2()
        {
            Assert.AreEqual(2, RomanToInteger.RomanToInt("II"));
        }

        [Test]
        public void When_III_Then_3()
        {
            Assert.AreEqual(3, RomanToInteger.RomanToInt("III"));
        }

        [Test]
        public void When_IV_Then_4()
        {
            Assert.AreEqual(4, RomanToInteger.RomanToInt("IV"));
        }

        [Test]
        public void When_V_Then_5()
        {
            Assert.AreEqual(5, RomanToInteger.RomanToInt("V"));
        }

        [Test]
        public void When_VI_Then_6()
        {
            Assert.AreEqual(6, RomanToInteger.RomanToInt("VI"));
        }

        [Test]
        public void When_MCMXCVI_Then_1996()
        {
            Assert.AreEqual(1996, RomanToInteger.RomanToInt("MCMXCVI"));
        }
    }
}