using System;
using System.Collections.Generic;

namespace Quelich.DataStructures;

public class QLinkedList
{
    // public void RemoveDuplicates(LinkedList<int> list)
    // {
    //     var map = new Dictionary<int, int>();

    //     var head = list.First;
    //     map[head.Value] = head.Value;
    //     while (head.next != null)
    //     {
    //         if (!map.ContainsValue(head.Next.Value))
    //         {
    //             map[head.Next.Value] = head.Next.Value;
    //             head = head.Next;
    //         }
    //         else
    //         {
    //             head.next = head.next.next;
    //         }
    //     }
    // }

    public bool IsPalindrome(LinkedList<char> list)
    {
        var head = list.First;
        var tail = list.Last;

        while (head != null && tail != null)
        {
            if (head.Value != tail.Value)
            {
                return false;
            }
            head = head.Next;
            tail = tail.Previous;
        }
        return true;
    }

    public char FindLoop(LinkedList<char> list)
    {
        var map = new Dictionary<int, int>();
        var head = list.First;

        while (head != null)
        {
            if (!map.ContainsValue(head.Value))
            {
                map[head.Value] = head.Value;
                head = head.Next;
            }
            else
            {
                return head.Value;
            }
        }
        return '0';
    }

    public void Print(LinkedList<int> llist)
    {
        System.Console.WriteLine("LinkedList: ");

        foreach (var item in llist)
        {
            System.Console.Write("{0}->", item);
        }
    }
}
