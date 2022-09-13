using System;
using System.Collections.Generic;
using System.Linq;
namespace SOLs.QArray
{
    public class DisappearedNumbers
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {

            var result = new List<int>();
            foreach(var num in nums)
            {
                var index = Math.Abs(num);
                if (nums[index-1] > 0) 
                    nums[index-1] *= -1;
            }
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    result.Add(i + 1);
                }
            }
            return result;
        }
    }
}