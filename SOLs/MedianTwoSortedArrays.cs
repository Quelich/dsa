using System;
using System.Collections.Generic;
using System.Text;

namespace SOLs
{
    public class MedianTwoSortedArrays : Merge
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] merged = MergeArrays(nums1,nums2);
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
