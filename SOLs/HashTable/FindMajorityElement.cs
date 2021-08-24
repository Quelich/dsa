using System;
using System.Collections.Generic;

namespace DefaultNamespace
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

    // internal class Program
    // {
    //     public static void Main(string[] args)
    //     {
    //         var nums = new[]{3,3,4};
    //         var sol = new FindMajorityElement();
    //         Console.WriteLine(sol.MajorityElement(nums));
    //     }
    // }
}