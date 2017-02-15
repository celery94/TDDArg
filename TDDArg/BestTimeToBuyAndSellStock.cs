using System;

namespace TDDArg
{
    public class BestTimeToBuyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length <= 1) return 0;

            for (int i = 0; i < prices.Length - 1; i++)
            {
                prices[i] = prices[i + 1] - prices[i];
            }

            var maxProfit = prices[0];
            var max = maxProfit;

            for (int i = 1; i < prices.Length - 1; i++)
            {
                if (prices[i] > maxProfit + prices[i])
                {
                    maxProfit = prices[i];
                }
                else
                {
                    maxProfit = maxProfit + prices[i];
                }

                max = Math.Max(max, maxProfit);
            }

            return max > 0 ? max : 0;
        }
    }
}