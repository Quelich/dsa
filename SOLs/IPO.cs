using System;
using System.Linq;
namespace SOLs
{
    //INCOMPLETE
    public class IPO
    {
        // public static void Main(string[] args)
        // {
        //     var k = 1;
        //     var w = 0;
        //     var profits = new[] { 1,2,3};
        //     var capital = new[] { 0,1,2};
        //     FindMaximizedCapital(k, w, profits, capital);
        // }
        public static int FindMaximizedCapital(int k, int w, int[] profits, int[] capital)
        {
            var limit = 0;
            for (var i = 0; i<profits.Length; i++)
            {
                if (limit >= k) break;
                Console.Write(" UserCapital: " + w);
                Console.Write(" Capital: " + w);
                //Selecting convenient project
                //Finding max-profit project
                var maxProfit = profits.Max();
                var maxIndex = profits.ToList().IndexOf(maxProfit);
                //Evaluating max value
                if (capital[maxIndex] <= w && profits[maxIndex] != -1)
                {
                    //Selecting the project that has max capital
                    w += profits[maxIndex];
                    limit++;
                    profits[maxIndex] = -1;
                }
                if (limit >= k) break;
                if (capital[i] <= w && profits[i] != -1)
                {
                    w += profits[i];
                    profits[i] = -1;
                }
                Console.Write(" Max Profit: " + maxProfit + "\n");
            }
            var utils = new ArrayUtils();
            Console.WriteLine("\nProfits array: ");
            utils.Print(profits);
            Console.WriteLine("Result: " + w);
            return w;
        }
    }
}