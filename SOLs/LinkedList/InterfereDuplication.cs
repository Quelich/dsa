namespace SOLs.LinkedList
{
    public class InterfereDuplication
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null) return null;
            var curr = head;
            while (curr.next != null)
            {
                if (curr.val == curr.next.val)
                    curr.next = curr.next.next;
                else
                    curr = curr.next;
            }
            return head;
        }

    }
}