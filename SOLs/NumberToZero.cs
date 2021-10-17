using System;

namespace SOLs
{
    //Leetcode Problems: 1342
    public class NumberToZero
    {
        public static int NumberOfSteps(int num)
        {
            var counter = 0;
            while (num != 0)
            {
                if (num % 2 == 0)
                {
                    num /= 2;
                }
                else
                {
                    num -= 1;
                }
                counter++;
            }
            return counter;
        }
    }
}