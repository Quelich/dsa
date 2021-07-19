namespace SOLs.LinkedList
{
    public class ReverseLinkedList
    {
        public ListNode ReverseList(ListNode head) {
            ListNode prev = null;
            var current = head;
            ListNode next = null;
            while(current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            head = prev;
            return head;
        }
    }
}