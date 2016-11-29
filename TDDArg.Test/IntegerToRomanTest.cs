using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class IntegerToRomanTest
    {
        [Test]
        public void Given_1_Then_I()
        {
            Assert.AreEqual("I",IntegerToRoman.IntToRoman(1));
        }

        [Test]
        public void Given_3_Then_III()
        {
            Assert.AreEqual("III",IntegerToRoman.IntToRoman(3));
        }

        [Test]
        public void Given_4_Then_IV()
        {
            Assert.AreEqual("IV",IntegerToRoman.IntToRoman(4));
        }

        [Test]
        public void Given_5_Then_V()
        {
            Assert.AreEqual("V",IntegerToRoman.IntToRoman(5));
        }

        [Test]
        public void Given_7_Then_V()
        {
            Assert.AreEqual("VII",IntegerToRoman.IntToRoman(7));
        }

        [Test]
        public void Given_9_Then_V()
        {
            Assert.AreEqual("IX",IntegerToRoman.IntToRoman(9));
        }

        [Test]
        public void Given_10_Then_X()
        {
            Assert.AreEqual("X",IntegerToRoman.IntToRoman(10));
        }

        [Test]
        public void Given_11_Then_XI()
        {
            Assert.AreEqual("XI",IntegerToRoman.IntToRoman(11));
        }

        [Test]
        public void Given_19_Then_XIX()
        {
            Assert.AreEqual("XIX",IntegerToRoman.IntToRoman(19));
        }

        [Test]
        public void Given_20_Then_XIX()
        {
            Assert.AreEqual("XX",IntegerToRoman.IntToRoman(20));
        }

        [Test]
        public void Given_60_Then_LX()
        {
            Assert.AreEqual("LX",IntegerToRoman.IntToRoman(60));
        }

        [Test]
        public void Given_100_Then_C()
        {
            Assert.AreEqual("C",IntegerToRoman.IntToRoman(100));
        }
    }
}