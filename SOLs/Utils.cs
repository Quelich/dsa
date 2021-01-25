using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace SOLs
{

    public class Utils
    {
        

        public string CountAndSay(int n)
        {
            return n.ToString();
        }

        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            IList<bool> results = new List<bool>();
            int maxValue = candies.Max();
            foreach (var VARIABLE in candies)
            {
                if ((VARIABLE + extraCandies) >= maxValue)
                {
                    results.Add(true);
                }
                else
                {
                    results.Add(false);
                }
            }
            return results;
        }
        public int[] FrequencySort(int[] nums)
        {
           
            for (int i = 0; i < nums.Length; i++)
            {
                
            }
            return null;
        }
        public string DefangIPaddr(string address)
        {
            string exchange = "[.]";
            string replaced = address.Replace(".", exchange);
            var print = new Print();
            print.PrintElements(replaced);
            return replaced;
        }

        
    }
}
