namespace SOLs.LinkedList
{
    public class RemoveNode
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n) {
            var start = new ListNode(0);
            ListNode slow = start, fast = start;
            slow.next = head;
    
            //Move fast in front so that the gap between slow and fast becomes n
            for(var i=1; i<=n+1; i++)   {
                fast = fast.next;
            }
            //Move fast to the end, maintaining the gap
            while(fast != null) {
                slow = slow.next;
                fast = fast.next;
            }
            //Skip the desired node
            slow.next = slow.next.next;
            return start.next;
        }
        public ListNode RemoveElementsAtValue(ListNode head, int val) {
            if(head == null) return null;
            ListNode post = RemoveElementsAtValue(head.next,val);
            if(head.val != val)
            {
                head.next = post;
                return head;
            }
            head = head.next;
            return post;
        }
    }
}