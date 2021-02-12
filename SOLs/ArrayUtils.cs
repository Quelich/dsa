using System;
using System.Collections.Generic;
using System.Text;


namespace SOLs
{
    public class ArrayUtils
    {

        public int[] Shuffle(int[] nums, int n) // 6 , 3 ->  0 1 2 3 4 5 [2,5,1,3,4,7]
        {

            // shuffled -> 0 3 1 4 2 5 -> [2,3,5,4,1,7]
            int[] x = new int[n];
            int[] y = new int[nums.Length];
            for (int i = 0; i < n; i++)
            {
                x[i] = nums[i];
            }
            int j = 0;
            for (int i = n+1; i < nums.Length; i++)
            {
                y[i] = nums[i];
            }
            Print print = new Print();
            print.PrintElements(x);
            print.PrintElements(y);
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
        public int[] sortIncrement(int[] array)
        {
            int temp;
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
                }
            }
            return array;
        }
    }
}
