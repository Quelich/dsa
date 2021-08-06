using System;

namespace SOLs.Hashtable
{
    public class QuelichHashMap
    {
        //TODO harness no array use
        private readonly bool[] _map;
        private readonly int[] _values;
        private readonly int _max;
        /** Initialize your data structure here. */
        public QuelichHashMap(int max)
        {
            _max = max;
            _map = new bool[_max];
            _values = new int[_max];
        }
        
    
        /** value will always be non-negative. */
        public void Put(int key, int value) {
            if (key < 0 || key > _max - 1 || value < 0 || value > _max - 1) return;
            // If the value exists, it will be updated
            _values[key] = value;
            _map[key] = true;
        }
    
        /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
        public int Get(int key)
        {
            if (key < 0 || key > _max - 1) return -1;
            if (!_map[key]) return -1;
            return _values[key];
        }
    
        /** Removes the mapping of the specified value key if this map contains a mapping for the key */
        public void Remove(int key)
        {
            if (key < 0 || key > _max - 1) return;
            _map[key] = false;
        }
    }
    // internal class Program
    //  {
    //      public static void Main(string[] args)
    //      {
    //          var myHashMap = new QuelichHashMap(1000001);
    //          var result = 0;
    //          myHashMap.Put(1, 1); // The map is now [[1,1]]
    //          myHashMap.Put(2, 2); // The map is now [[1,1], [2,2]]
    //          result = myHashMap.Get(1);    // return 1, The map is now [[1,1], [2,2]]
    //          Console.WriteLine(result);
    //          result = myHashMap.Get(3);    // return -1 (i.e., not found), The map is now [[1,1], [2,2]]
    //          Console.WriteLine(result);
    //          myHashMap.Put(2, 1); // The map is now [[1,1], [2,1]] (i.e., update the existing value)
    //          result = myHashMap.Get(2);    // return 1, The map is now [[1,1], [2,1]]
    //          Console.WriteLine(result);
    //          myHashMap.Remove(2); // remove the mapping for 2, The map is now [[1,1]]
    //          result = myHashMap.Get(2);    // return -1 (i.e., not found), The map is now [[1,1]]
    //          Console.WriteLine(result);
    //      }
    //  }
}