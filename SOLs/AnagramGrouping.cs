using System;
using System.Collections.Generic;

namespace SOLs
{
    public class AnagramGrouping
    {
        public static bool IsAnagram(string s, string t) {
            if(s.Length != t.Length) return false;
            var ss = s.ToCharArray();
            var tt = t.ToCharArray();
            Array.Sort(ss);
            Array.Sort(tt);
            for (var i = 0; i < ss.Length; i++)
            {
                if (ss[i] != tt[i]) return false;
            }
            return true;
        }
        public IList<IList<string>> GroupAnagrams(string[] strs) {
        
        }
    }
}