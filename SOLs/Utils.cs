using System;

namespace SOLs
{
    public class Utils
    {
        public void PrintHelloWorld() => Console.WriteLine("Hello World");
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}