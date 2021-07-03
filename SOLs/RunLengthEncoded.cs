using System;
using System.Collections.Generic;

namespace SOLs
{
    public class RunLengthEncoded
    {
        //Leetcode Problems: 1313
        // public static void Main(string[] args)
        // {
        //     var input = new int[]{1, 2,3,4};
        //     Print(DecompressRLElist(input));
        //
        // }
        public static int[] DecompressRLElist(int[] nums)
        {
            var freq = 0;
            var val = 0;
            var freqList = new List<int>();
            for (var i = 0; i< nums.Length; i++)
            {
                if (2*i+1 > nums.Length || 2*i > nums.Length) break;
                freq = nums[2 * i];
                val = nums[2*i+1];
                for (var j = 0; j< freq; j++)
                {
                    freqList.Add(val);
                }
            }
            var result = new int[freqList.Count];
            //Not creating a new variable, rather over-using val variable safely
            val = 0;
            foreach (var f in freqList)
            {
                result[val] = f;
                val++;
            }
            return result;
        }
        private static void Print<T>(IEnumerable<T> array)
        {
            foreach (var x in array)
            {
                Console.Write(x + " ");
            }
        }
    }
}