using System;

namespace SOLs.Array
{
    public class BuySellStock
    {
        public int MaxProfit(int[] prices)
        {
            var currentProfit = 0;
            var maxProfit = 0;
            for (var i = 1; i < prices.Length; i++)
            {
                currentProfit += prices[i] - prices[i - 1];
                currentProfit = Math.Max(0, currentProfit);
                maxProfit = Math.Max(currentProfit, maxProfit);
            }

            return maxProfit;
        }
    }
}