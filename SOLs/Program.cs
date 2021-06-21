using System;
using System.Collections.Generic;
using SOLs;

namespace SOLs
{
    class Program : Utils
    {
        private static Print print = new Print();

        static void Main(string[] args)
        {
            var performance = System.Diagnostics.Stopwatch.StartNew();
            //****************CODE*****************
            ArrayUtils arrayUtils = new ArrayUtils();
            string[] input = { "a", "banana", "app", "appl", "ap", "apply", "apple" };
            arrayUtils.LongestWord(input);

            //****************CODE*****************
            performance.Stop();
            Console.WriteLine("Executed in " + performance.ElapsedMilliseconds.ToString() + " ms");
        }
    }
}