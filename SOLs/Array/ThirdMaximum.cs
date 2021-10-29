using System;
using System.Collections.Generic;

namespace SOLs.QArray
{
    public class ThirdMaximum
    {
        public int ThirdMax(int[] nums)
        {
            Array.Sort(nums);
            var map = new Dictionary<int, int>();
            var counter = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (!map.ContainsValue(nums[i]))
                {
                    map[counter] = nums[i];
                    counter++;
                }
            }
            if (map.Count < 3)
            {
                return map[map.Count - 1];
            }
          
            return map[map.Count - 3];
        }
    }
}