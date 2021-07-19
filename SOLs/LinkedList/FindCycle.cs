using System.Collections.Generic;

namespace SOLs.LinkedList
{
    public class FindCycle
    {
        public bool HasCycle(ListNode head)
        {
            if(head?.next == null) return false;
            var slowPointer = head;
            var fastPointer = head.next;
            while(fastPointer != null && fastPointer.next != null)
            {
                if(slowPointer == fastPointer ||
                   fastPointer.next == slowPointer) return true;
                fastPointer = fastPointer.next.next;
                slowPointer = slowPointer.next;
            }
            return false;
        }
        public ListNode DetectCycle(ListNode head)
        {
            if(head == null) return null;
            var container = new List<ListNode>();
            while(head.next != null)
            {
                if (container.Contains(head)) return head;
                container.Add(head);
                head = head.next;
            }
            return null;
        }
    }
}