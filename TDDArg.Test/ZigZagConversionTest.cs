using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class ZigZagConversionTest
    {
        [Test]
        public void Convert_1_Row()
        {
            var input = "PAYPALISHIRING";

            var result = ZigZagConversion.Convert(input, 1);

            Assert.AreEqual("PAYPALISHIRING",result);
        }

        [Test]
        public void Convert_2_Row()
        {
            var input = "PAYPALISHIRING";

            var result = ZigZagConversion.Convert(input, 2);

            Assert.AreEqual("PPIINAYALSHRIG",result);
        }

        [Test]
        public void Convert_3_Row()
        {
            var input = "PAYPALISHIRING";

            var result = ZigZagConversion.Convert(input, 3);

            Assert.AreEqual("PAHNAPLSIIGYIR",result);
        }

        [Test]
        public void Convert_4_Row()
        {
            var input = "PAYPALISHIRING";

            var result = ZigZagConversion.Convert(input, 4);

            Assert.AreEqual("PINAASRGYHPLII",result);
        }
    }
}