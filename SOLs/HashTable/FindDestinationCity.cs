using System;
using System.Collections.Generic;

namespace SOLs.HashTable
{
    public class FindDestinationCity
    {
        public string DestCity(IList<IList<string>> paths) {
            var hashSet = new HashSet<string>();
            foreach(var path in paths)
            {
                for (var i = 0; i<path.Count;i++)
                {
                    if(i!=0 && !hashSet.Contains(path[i]))
                        hashSet.Add(path[i]);
                }
            }
            foreach(var path in paths)
            {
                foreach (var pathName in path)
                {
                    if (!hashSet.Contains(pathName))
                        return pathName;
                }
            }
            return null;
        }
    }
}