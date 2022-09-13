using System;
using System.Collections.Generic;

namespace SOLs.QArray
{
    //Leetcode Problems: 1313
    public class RunLengthEncoded
    {
        public int[] DecompressRLElist(int[] nums)
        {
            var freq = 0;
            var val = 0;
            var freqList = new List<int>();
            for (var i = 0; i < nums.Length; i++)
            {
                if (2 * i + 1 > nums.Length || 2 * i > nums.Length) break;
                freq = nums[2 * i];
                val = nums[2 * i + 1];
                for (var j = 0; j < freq; j++)
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
    }
}