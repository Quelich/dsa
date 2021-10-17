using System.Collections.Generic;

namespace SOLs.LinkedList
{
    public class PalindromeLinkedList
    {
        public bool IsPalindrome(ListNode head)
        {
            ListNode slow = head;
            var ispalin = true;
            var stack = new Stack<int>();
            while (slow != null)
            {
                stack.Push(slow.val);
                slow = slow.next;
            }
            while (head != null)
            {
                var i = stack.Pop();
                if (head.val == i)
                {
                    ispalin = true;
                }
                else
                {
                    ispalin = false;
                    break;
                }
                head = head.next;
            }
            return ispalin;
        }
    }
}