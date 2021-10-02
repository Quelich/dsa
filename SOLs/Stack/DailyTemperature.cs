using System;
using System.Collections.Generic;
public class DailyTemperature
{
    public static int[] DailyTemperatures(int[] temperatures)
    {
        int[] result = new int[temperatures.Length];
        Stack<int> stack = new Stack<int>();
        for (int i = 0; i < temperatures.Length; i++)
        {
            while (stack.Count > 0 && temperatures[stack.Peek()] < temperatures[i])
            {
                int index = stack.Pop();
                result[index] = i - index;
            }
            stack.Push(i);
        }
        return result;
    }
}
