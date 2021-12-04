namespace SOLs.DP
{
    public class Tribonacci
    {
        public int GetNthValue(int n)
        {
            var nums = new int[38];
            nums[0] = 0;
            nums[1] = 1;
            nums[2] = 1;
            for (var i = 3; i < n+1; i++)
            {
                nums[i] = nums[i - 1] + nums[i - 2] + nums[i - 3];
            }
            return nums[n];
        }
    }
}