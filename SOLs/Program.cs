using System;
using SOLs;
using System.Collections.Generic;

namespace SOLs
{
    class Program : Utils
    {
        private static Print print = new Print();
        //***************IMPLEMENTATION*********************
        static void Main(string[] args)
        {
            var performance = System.Diagnostics.Stopwatch.StartNew();
            var arrayUtils = new ArrayUtils();
            int[] nums = { 2, 5, 1, 3, 4, 7 };
            print.PrintElements(arrayUtils.Shuffle(nums, 3));
            performance.Stop();
            Console.WriteLine("Executed in " + performance.ElapsedMilliseconds.ToString() + " ms");
        }
        //***************IMPLEMENTATION*********************
    }
}
