using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class BestTimeToBuyAndSellStockTest
    {
        [Test]
        public void Given_prices_When_find_Then_return()
        {
            var prices = new int[] { 7, 1, 5, 3, 6, 4 };

            Assert.AreEqual(5, new BestTimeToBuyAndSellStock().MaxProfit(prices));
        }
    }
}