using System;
using System.Collections.Generic;

namespace SOLs.HashTable
{
    public class FindMajorityElement
    {
        public int MajorityElement(int[] nums)
        {
            var map = new Dictionary<int, int>();
            // nums values as keys
            var result = 0;
            foreach (var num in nums)
            {
                // Adding the pair to the dictionary
                if (!map.ContainsKey(num))
                    map.Add(num, 1);
                // Increasing the value, which is a counter for the key
                else
                {
                    map[num] += 1;
                   
                }
                if (map[num] > nums.Length / 2)
                    result = num;
            }
            return result;
        }
        
    }
}