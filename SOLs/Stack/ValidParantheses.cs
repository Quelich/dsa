using System;
using System.Collections.Generic;

namespace SOLs.Stack
{

    public class ValidParantheses
    {
        public bool IsValid(string s)
        {
            if (s.Length % 2 != 0) return false;
            var stack = new Stack<char>();

            foreach (var c in s)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    var open = stack.Pop();
                    if (c == ')' && open != '(')
                    {
                        return false;
                    }
                    if (c == ']' && open != '[')
                    {
                        return false;
                    }
                    if (c == '}' && open != '{')
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
    }
}