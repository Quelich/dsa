using System;
using System.Collections;
using SOLs;
using System.Collections.Generic;

namespace SOLs {
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode (int val = 0, ListNode next = null) {
            this.val = val;
            this.next = next;
        }
    }
    public class add_two_numbers {
        
        public ListNode addTwoNumbers(ListNode l1, ListNode l2) {
            var dummyHead = new ListNode(0);
            ListNode p = l1, q = l2, curr = dummyHead;
            var carry = 0;
            while (p != null || q != null) {
                var x = (p != null) ? p.val : 0;
                var y = (q != null) ? q.val : 0;
                var sum = carry + x + y;
                carry = sum / 10;
                curr.next = new ListNode(sum % 10);
                curr = curr.next;
                if (p != null) p = p.next;
                if (q != null) q = q.next;
            }
            if (carry > 0) {
                curr.next = new ListNode(carry);
            }
            return dummyHead.next;
        }
    }
  
    
}