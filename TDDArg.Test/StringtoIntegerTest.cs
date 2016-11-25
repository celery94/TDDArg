using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class StringtoIntegerTest
    {
        [Test]
        public void StringtoInteger_1234567890()
        {
            Assert.AreEqual(1234567890, StringtoInteger.StringtoIntegerFunc("1234567890"));
        }

        [Test]
        public void StringtoInteger_0()
        {
            Assert.AreEqual(0, StringtoInteger.StringtoIntegerFunc("0"));
        }

        [Test]
        public void StringtoInteger_Negative_123()
        {
            Assert.AreEqual(-123, StringtoInteger.StringtoIntegerFunc("-123"));
        }

        [Test]
        public void StringtoInteger_MaxInt()
        {
            Assert.AreEqual(2147483647, StringtoInteger.StringtoIntegerFunc("2147483647"));
        }

        [Test]
        public void StringtoInteger_MaxInt_Overflow()
        {
            Assert.AreEqual(int.MaxValue, StringtoInteger.StringtoIntegerFunc("2147483648"));
        }

        [Test]
        public void StringtoInteger_MaxInt_Overflow_More()
        {
            Assert.AreEqual(int.MaxValue, StringtoInteger.StringtoIntegerFunc("    10522545459"));
        }

        [Test]
        public void StringtoInteger_MinInt_Less()
        {
            Assert.AreEqual(-2147483647, StringtoInteger.StringtoIntegerFunc("-2147483647"));
        }
        [Test]
        public void StringtoInteger_MinInt()
        {
            Assert.AreEqual(int.MinValue, StringtoInteger.StringtoIntegerFunc("-2147483648"));
        }

        [Test]
        public void StringtoInteger_MinInt_Overflow()
        {
            Assert.AreEqual(int.MinValue, StringtoInteger.StringtoIntegerFunc("-2147483649"));
        }

        [Test]
        public void StringtoInteger_MinInt_Overflow_More()
        {
            Assert.AreEqual(int.MinValue, StringtoInteger.StringtoIntegerFunc("    -10326662300y"));
        }

        [Test]
        public void StringtoInteger_Plus()
        {
            Assert.AreEqual(12, StringtoInteger.StringtoIntegerFunc("+12"));
        }

        [Test]
        public void StringtoInteger_Space()
        {
            Assert.AreEqual(12, StringtoInteger.StringtoIntegerFunc("    12"));
        }

        [Test]
        public void StringtoInteger_WithString()
        {
            Assert.AreEqual(12, StringtoInteger.StringtoIntegerFunc("+12a123"));
        }
    }
}