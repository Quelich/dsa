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

    // internal class Program
    // {
    //     public static void Main(string[] args)
    //     {
    //         var solution = new GetTwoSum();
    //         var input = new[] {2, 7, 11, 15};
    //         var target = 9;
    //         var print = new Print();
    //         var result = solution.TwoSum(input, target);
    //         print.PrintElements(result);
    //     }
    // }
}