using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class ReverseIntTest
    {
        [Test]
        public void Reverse_One()
        {
            Assert.AreEqual(321, ReverseInt.Reverse(123));
        }

        [Test]
        public void Reverse_Nagetive()
        {
            Assert.AreEqual(-321, ReverseInt.Reverse(-123));
        }

        [Test]
        public void Reverse_10()
        {
            Assert.AreEqual(1, ReverseInt.Reverse(10));
        }

        [Test]
        public void Reverse_Max()
        {
            Assert.AreEqual(0, ReverseInt.Reverse(1534236469));
        }

        [Test]
        public void Reverse_Min()
        {
            Assert.AreEqual(0, ReverseInt.Reverse(-2147483648));
        }
    }
}