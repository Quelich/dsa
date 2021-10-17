using System;
using System.Collections.Generic;

namespace SOLs.HashTable
{
    public class SearchSingle
    {
        public int SingleNumber(int[] nums)
        {
            var keys = new HashSet<int>();
            foreach (var t in nums)
            {
                if (!keys.Contains(t))
                {
                    keys.Add(t);
                }
                else
                {
                    keys.Remove(t);
                }
            }

            foreach (var key in keys)
            {
                return key;
            }

            return -1;
        }
    }
}