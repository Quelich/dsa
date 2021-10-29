using System;

namespace SOLs.QArray
{
    public class MoveZeros
    {
        public int[] Move(int[] nums)
        {
            var ptr1 = 0; // traverse the array
            var ptr2 = 0; // traverse non-zero elements
            while(ptr1 < nums.Length)
            {
                if(nums[ptr1] != 0)
                {
                    var temp = nums[ptr1];
                    nums[ptr1] = nums[ptr2];
                    nums[ptr2] = temp;
                    ptr1++;
                    ptr2++;
                }
            }
            return nums;
        }   
    }
}