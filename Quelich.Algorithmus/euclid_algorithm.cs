using System;

namespace SOLs.Quelich.Algorithmus
{
    public class euclid_algorithm
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Solution(4,3));
        }

        public static int Solution(int m, int n)
        {
            var remainder = -1;
            var stepCounter = 1;
            while (remainder != 0)
            {
                remainder = m % n;
                m = n;
                n = remainder;
                //Control Element for runtime-use
                Console.WriteLine("Step: " + stepCounter + "\nRemainder: " + remainder + "\tM Value: " + m + "\tN Value: " + n); 
                stepCounter++;
            }
            return m;
        }
    }
}