using System;
using System.Collections.Generic;
using System.Linq;

namespace SOLs.HashTable
{
    public class GetTwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var map = new Dictionary<int,int>();
            for (var i = 0; i < nums.Length; i++) {
                map.Add(nums[i], i);
            }
            for (var i = 0; i < nums.Length; i++) {
                var complement = target - nums[i];
                if (map.ContainsKey(complement) && map.GetValueOrDefault(complement) != i) {
                    return new [] { i, map.GetValueOrDefault(complement) };
                }
            }
            // In case there is no solution, we'll just return null
            return null;
        }
    }
}