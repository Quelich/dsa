using System;
using System.Collections.Generic;
using System.Linq;

namespace SOLs
{
    public class WaterContainer
    {
        // public static void Main(string[] args)
        // {
        //     
        //     int[] height3 = {1,8,6,2,5,4,8,3,7};
        //     Console.WriteLine( MaxArea(height3));
        // }
        
        public static int MaxArea(int[] height) {
            int ans = 0, i = 0, j = height.Length-1, res = 0;
            while (i < j) {
                if (height[i] <= height[j]) {
                    res = height[i] * (j - i);
                    i++;
                } else {
                    res = height[j] * (j - i);
                    j--;
                }
                if (res > ans) ans = res;
            }
            return ans;
        }
    }
}