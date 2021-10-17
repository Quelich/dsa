using System;
using System.Collections.Generic;
using System.Linq;

namespace SOLs.HashTable
{
    public class SearchIntersection
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            // the Resultant Hash that holds the non-duplicate numbers
            var resultHash = new HashSet<int>();
            // The loop to find the intersects
            foreach (var num1 in nums1)
            {
                // The flag indicates the intersect is found
                var isFound = false;
                // Traversing nums2 to compare its elements to the nums1's element
                foreach (var num2 in nums2)
                {
                    // If the elements are equivalent, the intersection is present
                    if (num1 == num2)
                    {
                        isFound = true;
                    }
                }
                // If no intersection is present, move to the next nums1 element
                if (!isFound) continue;
                // If the intersection is present, then check out if the hash table already includes the num1
                if (!resultHash.Contains(num1))
                {
                    // If not, add it to the hash table
                    resultHash.Add(num1);
                }
            }
            // Initialize an array to copy elements of the hash table in it
            var resultArray = new int[resultHash.Count];
            var i = 0;
            // Copying the elements into 
            foreach (var value in resultHash)
            {
                resultArray[i] = value;
                i++;
            }
            return resultArray;
        }
    }
}