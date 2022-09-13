using System;

namespace SOLs
{
    //Leetcode Problems: 1281
    public class SubtractProductInteger
    {
        public static int SubtractProductAndSum(int n)
        {
            var product = 1;
            var sum = 0;
            var remainder = 0;
            while (n > 0)
            {
                remainder = n % 10;
                sum += remainder;
                product *= remainder;
                n /= 10;
            }
            return product - sum;
        }
    }
}