using System;
namespace SOLs
{
    public class MaximumSubarray
    {
        public static int MaxSubArray(int[] nums)
        {
            int max_so_far = int.MinValue,
                max_ending_here = 0;
            
            foreach (var variable in nums)
            {
                max_ending_here = max_ending_here + variable;
			
                if (max_so_far < max_ending_here)
                    max_so_far = max_ending_here;
			
                if (max_ending_here < 0)
                    max_ending_here = 0;
            }
		
            return max_so_far;
        }       
    }
}