using System;
using System.Collections.Generic;

namespace SOLs.HashTable
{
    public class MorseCode
    {
        public int UniqueMorseRepresentations(string[] words)
        {
            var morseCodes = new[]{".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};
            var morseSet = new HashSet<string>();
            var morse = string.Empty;
            foreach (var word in words)
            {
                foreach (var t in word)
                {
                    morse += morseCodes[t - 'a'];
                }
                morseSet.Add(morse);
                morse = string.Empty;
            }
            return morseSet.Count;
        }
    }
    // internal class Program
    // {
    //     public static void Main(string[] args)
    //     {
    //         var sol = new MorseCode();
    //         var words = new[] {"gin", "zen", "gig", "msg"};
    //         var result = sol.UniqueMorseRepresentations(words);
    //         Console.WriteLine(result);
    //     }
    // }
}