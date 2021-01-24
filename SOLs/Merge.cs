using System;
using System.Collections.Generic;
using SOLs;
using System.Linq;

namespace SOLs
{
    public class Merge : Utils
    {
        public int[] MergeArrays(int[] arr1, int[] arr2)
        {
            int[] front = arr1;
            int[] back = arr2;
            int[] combined = front.Concat(back).ToArray();
            return combined;
        }
        //public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        //{
        //    ListNode[] lists = new ListNode[] { l1,l2};
        //    foreach (var VARIABLE in lists)
        //    {
             
                
        //    }
        //    return null;
        //}
        //public ListNode MergeKLists(ListNode[] lists)
        //{

        //    return null;
        //}
    }
}
