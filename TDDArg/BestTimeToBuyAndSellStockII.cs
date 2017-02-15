namespace TDDArg
{
    public class BestTimeToBuyAndSellStockII
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length <= 1) return 0;

            var profit = 0;
            var buy = -1;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                if (buy == -1)
                {
                    if (prices[i + 1] > prices[i])
                    {
                        buy = prices[i];
                    }
                }
                else
                {
                    if (prices[i + 1] > prices[i])
                    {
                        continue;
                    }
                    else
                    {
                        profit += prices[i] - buy;
                        buy = -1;
                    }
                }
            }

            if (buy != -1) profit += prices[prices.Length - 1] - buy;

            return profit;
        }
    }
}