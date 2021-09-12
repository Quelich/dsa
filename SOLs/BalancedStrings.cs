using System;

namespace SOLs
{
    //Leetcode Problems: 1221
    public class BalancedStrings
    {
        public static int BalancedStringSplit(string s)
        {
            var answer = 0;
            var balance = 0;
            foreach (var t in s)
            {
                if (balance == 0) answer++;
                if (t == 'L')
                {
                    balance++;
                }
                else
                {
                    balance--;
                }
                
            }
            return answer;
        }
    }
}