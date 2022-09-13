using System;
using System.Collections.Generic;

namespace SOLs.HashTable
{
    public class IsomorphicStrings
    {

        public bool IsIsomorphic(string s, string t)
        {
            // Constraints
            if (s.Length != t.Length || s.Length < 1 || s.Length > 500000) return false;
            var sMap = new int[128];
            var tMap = new int[128];

            for (var i = 0; i < s.Length; i++)
            {
                if (sMap[s[i]] != tMap[t[i]]) return false;
                sMap[s[i]] = i + 1;
                tMap[t[i]] = i + 1;
            }
            return true;
        }
    }
}