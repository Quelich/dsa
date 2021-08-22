using System;
using System.Collections.Generic;

namespace DefaultNamespace
{
    public class RomanToIntegers
    {
        // Leetcode 13
        public int RomanToInt(string s)
        {
            // Mapping roman characters into integers
            var map = new Dictionary<char, int>()
            {
                {'I',1},
                {'V',5},
                {'X',10},
                {'L',50},
                {'C',100},
                {'D',500},
                {'M',1000}
            };
            // Count on the last element at first
            var result = map[s[^1]];
            // Starting after the last element
            for (var i = s.Length-2; i >= 0 ; i--)
            {
                // If the following element is less than the current element,
                // do addition
                if (map[s[i]] < map[s[i + 1]])
                    result -= map[s[i]];
                // If not, do subtraction
                else
                    result += map[s[i]];
                
            }
            return result;
        }
    }

    // internal class Program
    // {
    //     public static void Main(string[] args)
    //     {
    //         var input = 58;
    //         var sol = new RomanToIntegers();
    //         Console.WriteLine(sol.RomanToInt(input));
    //     }
    // }
}