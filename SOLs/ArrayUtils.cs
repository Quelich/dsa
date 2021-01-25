using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace SOLs
{
    public class ArrayUtils
    {
        //public int[] CopyArray(int[] array, int from, int destination)
        //{
        //    for (int i = 0; i < UPPER; i++)
        //    {
                
        //    }
        //}
        public int[] Shuffle(int[] nums, int n)
        {
            int[] x = new int[nums.Length];
            int[] y = new int[nums.Length];
            
            for (int i = 0; i < n; i++)
            {
                x[i] = nums[i];
            }

            for (int i = n; i < nums.Length; i++)
            {
                y[i-n] = nums[i];
            }

            int[] modified = new int[nums.Length];
            for (int i = 0; i < nums.Length; i += 2)
            {
                modified[i] = x[i];
               
            }

            for (int i = n+1; i < nums.Length; i++)
            {
                modified[i] = y[i];
            }
            var print = new Print();
            print.PrintElements(modified);
            return null;
        }
    }
}
