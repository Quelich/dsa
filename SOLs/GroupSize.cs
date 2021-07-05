using System;
using System.Collections.Generic;
using System.Linq;

namespace SOLs
{
    //INCOMPLETE
    public class GroupSize
    {
        static ArrayUtils utils = new ArrayUtils();
        // public static void Main(string[] args)
        // {
        //     var groupSizes = new []{ 3,3,3,3,3,1,3};
        //     //GroupThePeople(groupSizes);
        //     foreach (var t in groupSizes)
        //     {
        //         groupCount(t, groupSizes);
        //     }
        //     
        // }
        public static IList<IList<int>> GroupThePeople(int[] groupSizes)
        {
            IList<IList<int>> result = new List<IList<int>>();
            var sizes = new List<int>();
            foreach (var t in groupSizes)
            {
                    
                if (!sizes.Contains(t))
                {
                    sizes.Add(t);
                }
            }
            
            foreach (var t in sizes )
            {
                IList<int> list = new List<int>(t);
                for (var i = 0; i < groupSizes.Length; i++)
                {
                    list.Add(groupSizes[i]);
                }
                result.Add(list);
            }
            
            utils.Print(sizes);
            return result;
        }

        private static int groupCount(int val, IEnumerable<int> list)
        {
            var counter = 0;
            var result = 0;
            foreach (var t in list)
            {
                //Console.WriteLine("Counter: " +counter);
                if (counter == t)
                {
                    counter = 1;
                    result++;
                }
                if (t == val)
                {
                    counter++;
                }
            }

            Console.WriteLine("Create " + result + " lists sized " + val);
            return result;
        }
    }
}