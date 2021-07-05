using System;

namespace SOLs
{
    public class TargetArray
    {

        // public static void Main(string[] args)
        // {
        //     var utils = new ArrayUtils();
        //     int[] nums = {1, 2, 3, 4, 0};
        //     int[] index = {0, 1, 2, 3, 0};
        //     utils.Print(CreateTargetArray(nums,index));
        // }
        public static int[] CreateTargetArray(int[] nums, int[] index)
        {
            var targetArray = new int[nums.Length];
            for (var i = 0; i < nums.Length+1; i++)
            {
                if (i == index.Length-1) break;
                if (index[i+1] >= index[i])
                {
                    for (var j = 0; j < nums.Length; j++)
                    {
                        if (j == nums.Length) break;
                        targetArray[j] = targetArray[j-1];
                    }
                }
                targetArray[index[i]] = nums[i];
                Console.WriteLine("Nums " + nums[i] + " to " + index[i] + " at target");
            }
         return targetArray;
        }
    }
}