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
    // internal class Program
    // {
    //     public static void Main(string[] args)
    //     {
    //         var sol = new FindDestinationCity();
    //         
    //         IList<IList<string>> input = new List<IList<string>>();
    //         IList<string> part1 = new List<string>();
    //         part1.Add("A");
    //         part1.Add("Z");
    //         input.Add(part1);
    //
    //         Console.WriteLine(sol.DestCity(input));
    //         
    //         
    //     }
    // }
}