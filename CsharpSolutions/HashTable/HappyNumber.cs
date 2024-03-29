using System;
using System.Collections.Generic;

namespace SOLs.HashTable
{
    public class HappyNumber
    {
        public bool IsHappy(int n)
        {
            // To store non-duplicate elements
            var hashNumbers = new HashSet<int>();
            while (n != 1)
            {
                // If the division loops, which does not lead to the result "1", return false
                if (hashNumbers.Contains(n)) return false;
                // Add the number to the hash set for further duplicate evaluation
                hashNumbers.Add(n);
                // Apply the rule: "replace the number by  the sum of the squares of its digits"
                n = ToSquareDigits(n);
            }
            // If the number pass the test above, it is a happy number
            return true;
        }
        // Calculate the sum of the squares of number's digits.
        private int ToSquareDigits(int number)
        {
            var sum = 0;
            var result = 0;
            while (number > 0)
            {
                sum = number % 10;
                sum *= sum;
                result += sum;
                number /= 10;
            }
            return result;
        }

    }
}