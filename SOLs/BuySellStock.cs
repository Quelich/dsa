using System;

namespace SOLs
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

    // internal class Program
    // {
    //     public static void Main(string[] args)
    //     {
    //         var sol = new BuySellStock();
    //         var prices = new[] {7,6,4,3,1};
    //         var result = sol.MaxProfit(prices);
    //         Console.WriteLine(result);
    //     }
    // }
}