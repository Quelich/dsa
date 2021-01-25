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
            int[] nums = new[] { 2, 5, 1, 3, 4, 7 };
            arrayUtils.Shuffle(nums, 3);
        }
    }
}
