using System;


namespace SOLs.HashTable
{
    //TODO add hash function later
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
            if (key < 0 || key > _max - 1) return false;
            return _bucket[key];
        }

    }
}