using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace SOLs
{

    public class Utils
    {
        public void PrintHelloWorld() => Console.WriteLine("Hello World");

        public void PrintElements(int[] array)
        {
            Console.Write("[");
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }

            Console.Write("]");
        }
        public void PrintElements(IList<bool> list)
        {
            Console.Write("[");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            Console.Write("]");
        }

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
            PrintElements(results);
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
            int.Parse(address);
            foreach (var VARIABLE in address)
            {
               
            }

            return address;
        }

    }
}
