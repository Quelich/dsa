using System;
public class RunningSum
{
    public int[] runningSum(int[] nums)
    {
        for (int i = 1; i < nums.Length; i++)
        {
            nums[i] += nums[i - 1];
        }
        return nums;
    }
}