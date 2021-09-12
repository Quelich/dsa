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