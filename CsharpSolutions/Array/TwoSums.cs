using System;
using System.Collections.Generic;

namespace SOLs.QArray
{
    public class TwoSums
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] final = new[] { nums[0], nums[1] };
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        final[0] = i;
                        final[1] = j;
                    }
                }
            }

            System.Console.WriteLine(final[0] + " " + final[1]);
            return final;
        }

    }
}

