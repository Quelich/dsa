using System;

namespace SOLs
{   
    //Leetcode Problems: 1689
    public class DeciBinary
    {
        // public static void Main(string[] args)
        // {
        //     var n = "27346209830709182346";
        //     Console.WriteLine(MinPartitions(n));
        // }
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