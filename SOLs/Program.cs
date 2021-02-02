using System;
using SOLs;
using System.Collections.Generic;

namespace SOLs
{
    class Program : Utils
    {
        static void Main(string[] args)
        {
            var arrayUtils = new ArrayUtils();
            uint value = 00000000000000000000000000001011;
            //***************IMPLEMENTATION*********************
            var performance = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine(arrayUtils.HammingWeight(value));
            performance.Stop();
            Console.WriteLine("Executed in " + performance.ElapsedMilliseconds.ToString() + " ms");
            //***************IMPLEMENTATION*********************



        }
    }
}
