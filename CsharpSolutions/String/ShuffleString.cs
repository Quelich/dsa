using System;
using System.Collections.Generic;
using System.Linq;

namespace SOLs.String
{
    //Leetcode Problems:1528 
    public class ShuffleString
    {
        public string RestoreString(string s, int[] indices)
        {
            var order = new char[indices.Length];
            var result = string.Empty;
            for (var i = 0; i < indices.Length; i++)
            {
                order[indices[i]] = s[i];
            }

            foreach (var character in order)
            {
                result += character;
            }
            return result;
            // return order.Aggregate(result, (current, character) => current + character);
        }
    }
}