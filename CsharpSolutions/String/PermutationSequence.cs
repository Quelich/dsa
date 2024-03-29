using System;
using System.Collections.Generic;
using System.Linq;

namespace SOLs.String
{
    //Leetcode Problems: 60
    public class PermutationSequence
    {
        private static readonly List<string> Permutations = new List<string>();
        private void permute(string str, int l, int r)
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
        public string swap(string a, int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            var s = new string(charArray);
            return s;
        }
        
        public string GetPermutation(int n, int k)
        {
            var num = string.Empty;
            for (var i = 1; i<=n; i++)
            {
                num += i.ToString();
            }
            permute(num,0,num.Length-1);
            return  Permutations[k-1];
        }
    }
}