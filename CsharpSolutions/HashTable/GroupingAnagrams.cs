using System;
using System.Collections.Generic;

namespace SOLs.HashTable
{

    public class GroupingAnagrams
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var charArray = new char[101];
            var map = new Dictionary<string, List<string>>();
            var currStr = string.Empty;
            var result = new List<IList<string>>();
            for (var i = 0; i < strs.Length; i++)
            {
                charArray = strs[i].ToCharArray();
                System.Array.Sort<char>(charArray);
                currStr = new string(charArray);
                if (!map.ContainsKey(currStr))
                {
                    map.Add(currStr, new List<string>());
                }
                map[currStr].Add(strs[i]);
            }

            return new List<IList<string>>(map.Values);
        }
    }
}