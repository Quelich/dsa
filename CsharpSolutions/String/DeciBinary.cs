using System;

namespace SOLs.String
{   
    //Leetcode Problems: 1689
    public class DeciBinary
    {
        public static int MinPartitions(string n)
        {
            var m = decimal.Parse(n);
            var counter = 0;
            while (m > 0)
            {
                //Console.WriteLine("n: " + m);
                m -= 11;
                counter++;
            }
            while (m > 0)
            {
                //Console.WriteLine("n: " + m);
                m -= 10;
                counter++;
            }

            //Console.WriteLine();
            return counter;
        }   
    }
}