using System;

namespace Quelich.DataStructures;

public class Array
{
    static void PrintArray(int[] arr)
    {
        System.Console.Write("Result: ");
        foreach (var i in arr)
        {
            System.Console.Write($"{i} ");
        }
    }

    void SwapEnds(int[] arr) { }

    // [1 2]3 4 5
    // 3 4 5 [1 2], k = 2
    static int[] ShiftLeft(int[] D, int k)
    {
        if (k < 0)
        {
            System.Console.WriteLine("Enter an index greater than zero");
            return new[] { 0 };
        }
        if (k == 0 || k == D.Length)
        {
            return D;
        }

        int i,
            j = 0;
        int n = D.Length;
        int[] r = new int[n];

        for (i = 0; i < n; i++)
        {
            if (i < k)
            {
                r[n - k + i] = D[i];
                continue;
            }

            r[j] = D[i];
            j++;
        }
        return r;
    }
}
