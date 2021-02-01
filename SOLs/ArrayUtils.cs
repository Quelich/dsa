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
                x[i]
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
    }
}
