using System;
using System.Collections.Generic;
using System.Linq;

namespace SOLs.Array
{
    public class WaterContainer
    {
        public static int MaxArea(int[] height)
        {
            int ans = 0, i = 0, j = height.Length - 1, res = 0;
            while (i < j)
            {
                if (height[i] <= height[j])
                {
                    res = height[i] * (j - i);
                    i++;
                }
                else
                {
                    res = height[j] * (j - i);
                    j--;
                }
                if (res > ans) ans = res;
            }
            return ans;
        }
    }
}