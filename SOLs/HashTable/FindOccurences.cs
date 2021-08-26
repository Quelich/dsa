using System;
using System.Collections.Generic;
using System.Linq;

namespace SOLs.HashTable
{
    public class FindOccurences
    {
        // 1941
        public bool AreOccurrencesEqual(string s) {
            var frequencies = new Dictionary<char,int>();
            foreach(var chr in s)
            {
                if(!frequencies.ContainsKey(chr))
                {
                    frequencies.Add(chr,1);
                }
                else
                {
                    frequencies[chr] += 1;
                }
            }

            var firstFrequency = frequencies.First().Value;
            foreach (var pair in frequencies)
            {
                if (pair.Value != firstFrequency)
                    return false;
            }
            return true;
        }
    }
    // internal class Program
    // {
    //     public static void Main(string[] args)
    //     {
    //         var sol = new FindOccurences();
    //         var s = "aaabb";
    //         var result = sol.AreOccurrencesEqual(s);
    //         Console.WriteLine(result);
    //
    //     }
    // }
}