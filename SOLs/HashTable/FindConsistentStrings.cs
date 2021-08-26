using System;
using System.Collections.Generic;

namespace SOLs.HashTable
{
    public class FindConsistentStrings
    {
        public int CountConsistentStrings(string allowed, string[] words)
        {
            var count = 0;
            foreach (var word in words)
            {
                for (var index = 0; index < word.Length; index++)
                {
                    if (!allowed.Contains(word[index])) break;
                    if (index == word.Length - 1) count++;
                }
            }
            return count;
        }
    }

    // internal class Program
    // {
    //     public static void Main(string[] args)
    //     {
    //         var sol = new FindConsistentStrings();
    //         var allowed = "abc";
    //         var words = new[] {"a","b","c","ab","ac","bc","abc"};
    //         var result = sol.CountConsistentStrings(allowed, words);
    //         Console.WriteLine(result);
    //     }
    // }
}