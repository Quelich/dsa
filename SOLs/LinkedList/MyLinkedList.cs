using System;
using System.Collections.Generic;

namespace SOLs.LinkedList
{
    public class Node
    {
        public int val;
        public Node next;
        public Node prev;

        public Node(int val)
        {
            val = val;
            next = null;
            prev = null;
        }
    }

    public class QLinkedList
    {

        /** Initialize your data structure here. */
        private Node head;
        private Node tail;
        public QLinkedList()
        {
            head = new Node(-1);
            tail = new Node(-1);
            head.next = tail;
            tail.prev = head;
        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            if (index < 0)
                return -1;

            var i = 0;
            var p = head;
            for (; i < index && p.next != tail; i++)
            {
                p = p.next;
            }

            return p.next.val;
        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {

            var nextNode = new Node(val) { next = head.next, prev = head };
            head.next = nextNode;
            nextNode.next.prev = nextNode;
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            var n = new Node(val) { next = tail, prev = tail.prev };
            tail.prev = n;
            n.prev.next = n;
        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            var i = 0;
            var p = head;
            for (; i < index && p.next != tail; i++)
            {
                p = p.next;
            }

            if (i != index) return;

            var n = new Node(val) { prev = p, next = p.next };
            p.next = n;
            n.next.prev = n;
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            var i = 0;
            var p = head;
            for (; i < index && p.next != tail; i++)
            {
                p = p.next;
            }

            if (p.next == tail)
                return;

            p.next = p.next.next;
            p.next.prev = p;
        }
    }
}