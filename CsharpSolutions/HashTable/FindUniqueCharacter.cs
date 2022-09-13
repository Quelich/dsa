using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace SOLs.HashTable
{
    public class FindUniqueCharacter
    {
        public int FirstUniqChar(string s) {
            var map = new Dictionary<char, int>();
            var indexer = 0;
            foreach(var chr in s)
            {
                if(!map.ContainsKey(chr))
                {
                    map.Add(chr, indexer);
                }
                else
                {
                    // delete the character for any duplicate
                    map[chr] = -1;
                }
                indexer++;
            }
            foreach (var pair in map)
            {
                if (pair.Value == -1) continue;
                return pair.Value;
            }
            return -1;
        }
    }
}