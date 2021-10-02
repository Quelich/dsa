using System;
using System.Collections.Generic;

// Leetcode 1381
public class CustomStack
{
    private int[] Stack;
    private int MaxSize;
    private int CurrentSize;
    public CustomStack(int maxSize)
    {
        MaxSize = maxSize;
        CurrentSize = 0;
        Stack = new int[maxSize];
    }

    public void Push(int x)
    {
        if(CurrentSize == MaxSize)
            return;
        Stack[CurrentSize++] = x;
    }

    public int Pop()
    {
        if(CurrentSize == 0)
            return -1;
        return Stack[--CurrentSize];
    }

    public void Increment(int k, int val)
    {
        if(CurrentSize == 0)
            return;
        if(k > CurrentSize)
            k = CurrentSize;
        for(var i = 0; i < k; i++)
        {
            Stack[i] += val;
        }
    }

    public void Print()
    {
        if(CurrentSize == 0)
        {
            System.Console.WriteLine("-1");
            return;
        }
        System.Console.Write("Stack:");
        for (var i = CurrentSize - 1; i >= 0; i--)
        {
            System.Console.Write(Stack[i] + " ");
        }
        System.Console.WriteLine();
    }
}