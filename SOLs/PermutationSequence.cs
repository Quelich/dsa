using System;
using System.Collections.Generic;
using System.Linq;

namespace SOLs
{
    //Leetcode Problems: 60
    public class PermutationSequence
    {
        private static readonly List<string> Permutations = new List<string>();
        private static void permute(string str,
            int l, int r)
        {
            if (l == r)
            {
                Permutations.Add(str);
            }
                
            else {
                for (int i = l; i <= r; i++) {
                    str = swap(str, l, i);
                    permute(str, l + 1, r);
                    str = swap(str, l, i);
                }
            }
        }
        public static string swap(String a, int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            var s = new string(charArray);
            return s;
        }
        
        public static string GetPermutation(int n, int k)
        {
            var num = string.Empty;
            for (var i = 1; i<=n; i++)
            {
                num += i.ToString();
            }
            permute(num,0,num.Length-1);
            return  Permutations[k-1];
        }

        public static void Main(string[] args)
        {
            
            Console.WriteLine(GetPermutation(4,9));
        }
    }
}