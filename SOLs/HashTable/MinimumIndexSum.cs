using System;
using System.Collections.Generic;

namespace SOLs.HashTable
{
    public class MinimumIndexSum
    {
        public string[] FindRestaurant(string[] list1, string[] list2) {
            var map = new List<string>(); 
            var maxLength = list1.Length + list2.Length - 2;
            for (var sum = 0; sum <= maxLength ; sum++)
            {
                // iterating over one list and check index
                // (Corresponding to given sum) in other list
                for (var i = 0; i <= sum; i++)
         
                    // put common Strings in resultant list
                    if (i < list1.Length && (sum - i) < list2.Length && list1[i] == list2[sum - i])
                        map.Add(list1[i]);
 
                // if common String found then break as we are
                // considering index sums in increasing order.
                if (map.Count > 0)
                    break;
            }
            var result = new string[map.Count];
            map.CopyTo(result, 0);
            return result;
        }
    }
    
    // internal class Program
    // {
    //     public static void Main(string[] args)
    //     {
    //         var sol = new MinimumIndexSum();
    //         var list1 = new[]{"Shogun","Tapioca Express","Burger King","KFC"};
    //         var list2 = new[]{"KFC","Burger King","Shogun"};
    //         var output = sol.FindRestaurant(list1, list2);
    //         foreach (var val in output)
    //         {
    //             Console.WriteLine(val);
    //         }
    //     }
    // }
}