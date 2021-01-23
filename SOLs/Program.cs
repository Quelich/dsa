using System;
using SOLs;
using System.Collections.Generic;

namespace SOLs
{
    class Program
    {
        static void Main(string[] args)
        {
            var sums = new TwoSums();
            int[] test1 = new[] { 2, 7, 11, 15 };
            int target1 = 9;
            sums.TwoSum(test1, target1);
            int[] test2 = new[] { 3, 2, 4 };
            int target2 = 6;
            sums.TwoSum(test2, target2);
            int[] test3 = new[] { 3, 3};
            int target3 = 6;
            sums.TwoSum(test3, target3);
        }
    }
}
