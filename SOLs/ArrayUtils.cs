using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace SOLs
{
    public class ArrayUtils
    {

        public int[] Shuffle(int[] nums, int n) // 6 , 3
        {
            int[] x = new int[nums.Length / 2 ];
            int[] y = new int[nums.Length / 2];
            for (int i = 0; i < n; i++)
            {
                
            }
            return null;
        }

        public int HammingWeight(uint n)
        {
            int count = 0;
            string array = n.ToString();
            
            foreach (var VARIABLE in array)
            {
                if (VARIABLE.Equals('1'))
                {
                    count++;
                }
            }
            return count;
        }

        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var mergeUtil = new Merge();
            int[] merged = mergeUtil.MergeArrays(nums1, nums2);
            Array.Sort(merged);
            var print = new Print();
            print.PrintElements(merged);
            if (merged.Length % 2 == 0) // even 
            {
                int half = merged[merged.Length / 2];
                double previous = merged[(merged.Length / 2) - 1];
                double median = (half + previous) / 2;
                return median;
            }
            double resultOdd = merged[(merged.Length - 1) / 2];
            return resultOdd;
        }
    }
}
