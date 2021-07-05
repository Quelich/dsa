using System;
using System.Collections.Generic;
using System.Linq;

namespace SOLs
{
    //Leetcode Problems: 462
    public class MinimumMovesEqualArray
    {
        // public static void Main(string[] args)
        // {
        //     var nums = new[] {1,0,0,8,6};
        //     Console.WriteLine(MinMoves2(nums));
        // }

        private delegate int ToAbs(int val1,int val2);
        public static int MinMoves2(int[] nums)
        {
            //Sorting nums
            Array.Sort(nums);
            var newNums = new int[nums.Length];
            for (var i = 0; i < nums.Length; i++)
            {
                newNums[i] = nums[i];
            }

            var median = nums[nums.Length / 2];
            var result = 0;
            //Anonymous method to calculate absolute value between the numbers, which is the distance 
            ToAbs getAbs = delegate(int val1, int val2)
            {
                
                if (val1 - val2 < 0)
                {
                    return (val1 - val2) * -1;
                }

                return val1 - val2;
            };
            //Calculating the moves
            foreach (var num in nums)
            {
                //distance = toAbs(avg, num);
                result += getAbs(median, num);
            }
            return result;
        }
    }
}