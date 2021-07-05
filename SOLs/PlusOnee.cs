using System;

namespace SOLs
{
    public class PlusOnee
    {
        // public static void Main(string[] args)
        // {
        //     var utils = new ArrayUtils();
        //     var nums = new[]{ 8,9,9};
        //     //P0lusOne(nums);
        //     utils.Print(PlusOne(nums));
        // }
        public static int[] PlusOne(int[] digits)
        {
            var i = digits.Length-1;
            var stop = false;
            while (!stop)
            {
                if (digits[i]+1 >= 10)
                {
                    digits[i] = 0;
                    digits[i - 1] += 1;
                }
                else
                {
                    digits[i] += 1;
                    stop = true;
                }
                i--;
            }
            return digits;
        }
    }
}