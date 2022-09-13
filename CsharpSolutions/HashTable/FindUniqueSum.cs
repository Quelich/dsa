using System;
using System.Collections;
using System.Collections.Generic;

namespace SOLs.HashTable
{
    public class FindUniqueSum
    {
        // 1748
        public int SumOfUnique(int[] nums)
        {
            var uniques = new HashSet<int>();
            var duplicates = new HashSet<int>();
            foreach(var num in nums)
            {
                if (uniques.Contains(num)) duplicates.Add(num);
                uniques.Add(num);
            }
            var sum = 0;
            foreach (var num in uniques)
                if(!duplicates.Contains(num))
                    sum += num;
            return sum;
        }
    }
}