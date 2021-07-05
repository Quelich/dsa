using System;

namespace SOLs
{
    //INCOMPLETE
    public class CoinChange
    {
        // public static void Main(string[] args)
        // {
        //     var coins = new int[] {1,2,5};
        //     Console.WriteLine(Change(5,coins));
        // }
        public static int Change(int amount, int[] coins)
        {
            var counter = 0;
            var copy = amount;
            for (var i = 0; i< coins.Length; i++)
            {
                while (amount != 0)
                {
                    amount -= coins[i];
                }

                Console.WriteLine("Counter: "+ counter);
                amount = copy;
                counter++;
            }
            
            return counter;
        }
    }
}