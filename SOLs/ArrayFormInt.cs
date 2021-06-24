using System.Collections.Generic;
using System.Linq;

namespace SOLs
{
    public class ArrayFormInt
    {
        
        public IList<int> AddToArrayForm(int[] num, int k)
        {
            int length = num.Length;
            int cur = k;
            IList<int> ans = new List<int>();
            int i = length;
            while (--i >= 0 || cur > 0)
            {
                if (i >= 0)
                {
                    cur += num[i];
                }
                ans.Add(cur % 10);
                cur /= 10;
            }

            var reverse = (List<int>) ans;
            reverse.Reverse();
            return reverse;
        }
    }
}