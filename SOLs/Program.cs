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
           
            Console.WriteLine(arrayUtils.HammingWeight(value));
        }
    }
}
