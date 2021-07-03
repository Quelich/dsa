using System;
using System.Collections.Generic;
using System.Linq;

namespace SOLs
{
    //Leetcode Problems:1528 
    public class ShuffleString
    {
        // public static void Main(string[] args)
        // {
        //     var s = "abc";
        //     int[] indices = {0,1,2};
        //     Console.WriteLine(RestoreString(s,indices));
        //     //RestoreString(s, indices);
        // }
        public static string RestoreString(string s, int[] indices)
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
        private static void Print(IEnumerable<char> array)
        {
            foreach (var x in array)
            {
                Console.Write(x + " ");
            }
        }
        
    }
}