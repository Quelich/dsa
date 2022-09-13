using System;
using System.Collections.Generic;

namespace SOLs.HashTable
{
    public class FindNearbyDuplicate
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var hashSet = new HashSet<int>();
            for(var i = 0; i < nums.Length; i++){
                if(i > k) hashSet.Remove(nums[i-k-1]);
                if(!hashSet.Add(nums[i])) return true;
            }
            return false;
        }
    }
}