using System.Collections.Generic;
using System.Linq;

namespace SOLs
{
    public class MergeSortedLists
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null)
                return l2;
            if (l2 == null)
                return l1;
            return l1;
        }   
       
    }
  
}