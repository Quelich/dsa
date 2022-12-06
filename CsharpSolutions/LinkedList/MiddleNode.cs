using System.Collections.Generic;

namespace SOLs.LinkedList;

public class MiddleNode
{
    public void GetMiddleNode()
    {
        var h1 = ll.First;
        int len = 1;
        while (h1.Next != null)
        {
            h1 = h1.Next;
            len++;
        }

        System.Console.WriteLine("Len: " + len);

        if (len == 1)
        {
            System.Console.WriteLine("Middle Node: " + ll.First.Value);
            return;
        }

        len = (len / 2);
        var h2 = ll.First;
        while (h2.Next != null)
        {
            if (len == 0)
            {
                System.Console.WriteLine("Middle Node: " + h2.Value);
            }
            len--;
            h2 = h2.Next;
        }
    }
}
