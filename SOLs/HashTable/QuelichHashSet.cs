using System;
using System.Collections;

namespace SOLs.LinkedList
{
    //TODO harness no array use
    public class QuelichHashSet
    {
        private readonly bool[] _bucket;
        private readonly int _max;
        /** Initialize your data structure here. */
        public QuelichHashSet(int max)
        {
            _max = max;
            _bucket = new bool[_max];
        }

        public void Add(int key)
        {
            if (key < 0 || key > _max - 1) return;
            _bucket[key] = true;
        }

        public void Remove(int key)
        {
            if (key < 0 || key > _max - 1) return;
            _bucket[key] = false;
        }

        /** Returns true if this set contains the specified element */
        public bool Contains(int key)
        {
            if (key < 0 || key > _max -1) return false;
            return _bucket[key];
        }

    }
}
//     internal class Program
//     {
//         public static void Main(string[] args)
//         {
//             var myHashSet = new QuelichHashTable(1000001);
//             var result = false;
//             myHashSet.Add(1);      // set = [1]
//             myHashSet.Add(2);      // set = [1, 2]
//             result = myHashSet.Contains(1); // return True
//             Console.WriteLine(result);
//             result = myHashSet.Contains(3); // return False, (not found)
//             Console.WriteLine(result);
//             myHashSet.Add(2);      // set = [1, 2]
//             result = myHashSet.Contains(2); // return True
//             Console.WriteLine(result);
//             myHashSet.Remove(2);   // set = [1]
//             result = myHashSet.Contains(2); // return False, (already removed)
//             Console.WriteLine(result);
//         }
//     }
// 