using System.Collections.Generic;

namespace SOLs
{
    //Leetcode problems: 412
    public class FizzBuzzFunction
    {
        // public static void Main(string[] args)
        // {
        //     var util = new ArrayUtils();
        //     var n = 15;
        //     util.Print(FizzBuzz(n));
        // }
        public static IList<string> FizzBuzz(int n)
        {
            var numbers = new int[n];
            var result = new string[n];
            for (var i = 0; i < n; i++)
            {
                numbers[i] = (i + 1);

            }

            for (var i = 0; i < n; i++)
            {
                if (numbers[i] % 3 == 0 && numbers[i] % 5 == 0) result[i] = "FizzBuzz";
                if (numbers[i] % 3 == 0 && numbers[i] % 5 != 0) result[i] = "Fizz";
                if (numbers[i] % 3 != 0 && numbers[i] % 5 == 0) result[i] = "Buzz";
                if (numbers[i] % 3 != 0 && numbers[i] % 5 != 0) result[i] = (i+1).ToString();
            }
            return result;
        }
    }
} 