using System;
namespace SOLs
{
    public class MaximumSubarray
    {
        // public static void Main(string[] args)
        // {
        //     int[] input = {-2,1,-3,4,-1,2,1,-5,4 };
        //     Console.WriteLine(MaxSubArray(input));
        // }
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