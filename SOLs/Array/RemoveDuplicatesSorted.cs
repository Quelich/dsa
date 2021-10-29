namespace SOLs.QArray
{
    // Leetcode #26
    public class RemoveDuplicatesSorted
    {
        public int RemoveDuplicates(int[] nums)
        {
            var i = 0;
            foreach (var n in nums)
                if (i == 0 || n > nums[i - 1])
                    nums[i++] = n;
            return i;
        }
    }
}