using System;

namespace SOLs
{
    public class OneBits
    {
        // Leetcode 191
        public static int HammingWeight(uint n)
        {
            var biString = Convert.ToString(n, toBase: 2);
            var result = 0;
            foreach (var chr in biString)
            {
                if (chr == '1')
                    result++;
            }
            return result;
        }
    }
}