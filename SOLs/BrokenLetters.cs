using System;

public class Solution {
    public int CanBeTypedWords(string text, string brokenLetters) {
        var count = 0;
        string[] strs = text.Split(" ");
        foreach(var str in strs)
        {
            foreach(var brokenletter in brokenLetters)
            {
                if(!str.Contains(brokenletter))
                {
                    count++;
                }
            }
        }
        return count;
    }
}

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         var text = "hello world";
//         var brokenLetters = "ad";
//         var result = new Solution().CanBeTypedWords(text, brokenLetters);
//         Console.WriteLine(result);
//     }
// }