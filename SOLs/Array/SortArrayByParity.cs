namespace SOLs.QArray
{
    // Leetcode #905
    public class SortArrayByParity
    {
        
        public int[] Sort(int[] nums)
        {
            var aPtr = 0;
            var temp = 0;
            for (var bPtr = 0; bPtr < nums.Length;bPtr++)
            {
                // Even number
                if(nums[bPtr] % 2 == 0)
                {
                    temp = nums[aPtr];
                    nums[aPtr] = nums[bPtr];
                    nums[bPtr] = temp;
                    aPtr++;
                }
            }
            return nums;
        }
    }
}