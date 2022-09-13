using System;
using System.Collections.Generic;
using System.Linq;

namespace SOLs.HashTable
{
    public class MaxBallsInBox
    {
        //1742
        public int CountBalls(int lowLimit, int highLimit)
        {
            var counts = new Dictionary<int, int>();
            var max = 0;
            for(var i = lowLimit; i<=highLimit; i++)
            {
                if (!counts.ContainsKey(SumDigits(i)))
                {
                    counts.Add(SumDigits(i), 0);
                }
                else
                {
                    counts[SumDigits(i)] += 1;
                    if (max <= counts[SumDigits(i)])
                        max = counts[SumDigits(i)];
                }
            }
            return max+1;
        }
        private int SumDigits(int num)
        {
            var sum = 0;
            while(num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
    }
}