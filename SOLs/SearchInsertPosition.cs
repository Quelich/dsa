using System;

namespace SOLs
{
    //Leetcode problems: 35 
    public class SearchInsertPosition
    {
        // public static void Main(string[] args)
        // {
        //     var target = 5;
        //     var nums = new[] {1,3,5,6};
        //     Console.WriteLine(SearchInsert(nums,target));
        // }
        public static int SearchInsert(int[] nums, int target) {
            var result = new int[nums.Length+1];
            for (var i = 0; i < nums.Length; i++)
            {
                result[i] = nums[i];
            }
            result[^1] = target;
            Array.Sort(result);
            for (var i = 0; i < result.Length + 1; i++)
            {
                if(i < result.Length && nums[i] == target) return i;
                if(result[i] == target) return i;
            }
            return Array.IndexOf(result,target);
        }
    }
}