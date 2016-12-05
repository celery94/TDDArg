using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class DivideTwoIntegersTest
    {
        [Test]
        public void Given_101_When_divide_0_Then_int_max()
        {
            Assert.AreEqual(int.MaxValue, DivideTwoIntegers.Divide(101, 0));
        }

        [Test]
        public void Given_int_min_When_divide_negative_1_Then_int_max()
        {
            Assert.AreEqual(int.MaxValue, DivideTwoIntegers.Divide(int.MinValue, -1));
        }

        [Test]
        public void Given_101_When_divide_max_than_101_Then_zero()
        {
            Assert.AreEqual(0, DivideTwoIntegers.Divide(101, 202));
        }

        [Test]
        public void Given_n101_When_divide_min_than_101_Then_zero()
        {
            Assert.AreEqual(0, DivideTwoIntegers.Divide(-101, -202));
        }

        [Test]
        public void Given_20_When_divide_5_Then_4()
        {
            Assert.AreEqual(4, DivideTwoIntegers.Divide(20, 5));
        }

        [Test]
        public void Given_20_When_divide_3_Then_6()
        {
            Assert.AreEqual(6, DivideTwoIntegers.Divide(20, 3));
        }

        [Test]
        public void Given_10_When_divide_10_Then_1()
        {
            Assert.AreEqual(1, DivideTwoIntegers.Divide(10, 10));
        }

        [Test]
        public void Given_2147483647_When_divide_2_Then_1073741823()
        {
            Assert.AreEqual(1073741823, DivideTwoIntegers.Divide(2147483647, 2));
        }

        [Test]
        public void Given_1100540749_When_divide_n1090366779_Then_n1()
        {
            Assert.AreEqual(-1, DivideTwoIntegers.Divide(1100540749, -1090366779));
        }
    }
}