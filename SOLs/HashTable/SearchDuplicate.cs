using System;
using System.Collections.Generic;

namespace SOLs.HashTable
{
    public class SearchDuplicate
    {
         public bool ContainsDuplicate(int[] nums)
         {
             var keys = new HashSet<int>();
                
             foreach (var num in nums)
             {
                 if (keys.Contains(num)) return true;
                 keys.Add(num);
             }

             return false;
         }
    }

    // internal class Program
    // {
    //     public static void Main(string[] args)
    //     {
    //         var input = new []{1,1,1,3,3,4,3,2,4,2};
    //         var solution = new SearchDuplicate();
    //         var result = solution.ContainsDuplicate(input);
    //         Console.WriteLine(result);
    //     }
    // }
}