using System;
using System.Collections.Generic;

namespace SOLs.HashTable
{
    public class SearchDuplicate
    {
        public bool ContainsDuplicate(int[] nums)
        {
            var keys = new HashSet<int>();

            foreach (var num in nums)
            {
                if (keys.Contains(num)) return true;
                keys.Add(num);
            }

            return false;
        }
    }
}