using System;
namespace SOLs.QArray
{
    public class RemoveDuplicatesSortedII
    {
        public int RemoveDuplicates(int[] nums)
        {
            var countDuplicates = new int[30000];
            var complement = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                countDuplicates[nums[i] + 10000]++;
                if (countDuplicates[nums[i] + 10000] > 2)
                {
                    nums[i] = nums[nums.Length - 1] + 1;
                    complement++;
                }
            }
            Array.Sort(nums); // quicksort is better to reduce time complexity
            return nums.Length - complement;
        }
    }
}