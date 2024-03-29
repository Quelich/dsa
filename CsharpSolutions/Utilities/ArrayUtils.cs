﻿using System;
using System.Linq;
using SOLs;


namespace SOLs
{
    public class ArrayUtils
    {

        public int[] Shuffle(int[] nums, int n) // 6 , 3 ->  0 1 2 3 4 5 [2,5,1,3,4,7]
        {
            int[] nums1 = new int[n];
            for (var i = 0; i < nums1.Length; i++)
            {
                nums1[i] = nums[i];
            }
            int[] nums2 = new int[n];
            for (var i = 0; i < nums2.Length; i++)
            {
                nums2[i] = nums[i + n];
            }
            var j = 0;
            for (var i = 0; i < nums.Length; i += 2)
            {
                nums[i] = nums1[j];
                j++;
            }
            j = 0;
            for (var i = 1; i <= nums.Length; i += 2)
            {
                nums[i] = nums2[j];
                j++;
            }
            return nums;
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
        public class Merge
        {
            public int[] MergeArrays(int[] arr1, int[] arr2)
            {
                int[] front = arr1;
                int[] back = arr2;
                int[] combined = front.Concat(back).ToArray();
                return combined;
            }
        }
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {

            var mergeUtil = new Merge();
            int[] merged = mergeUtil.MergeArrays(nums1, nums2);
            System.Array.Sort(merged);
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
        public int NumIdenticalPairs(int[] nums)
        {
            int pairCounter = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {

                    if (nums[i] == nums[j])
                    {
                        pairCounter++;
                    }
                }
            }
            return pairCounter;
        }

        public string LongestWord(string[] words) //INCOMPLETE
        {
            int longest = 0;
            string longest_str = "";
            var sort = from a in words
                       orderby a
                       select a;
            string[] words_final = sort.ToArray();
            for (var i = 0; i < words_final.Length; i++)
            {
                int tempLongest = words_final[i].Length;
                if (tempLongest > longest)
                {
                    longest = tempLongest;
                    longest_str = words_final[i];

                }
                tempLongest = longest;
            }

            return null;
        }

    }
}