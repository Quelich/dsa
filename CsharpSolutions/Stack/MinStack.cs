using System;
using System.Collections.Generic;
namespace SOLs.Stack
{

    public class MinStack
    {
        // Push element x onto stack.
        private Stack<int> stack;
        // Keeps the present and minimum element in the stack
        private Stack<int> minStack;
        public MinStack()
        {
            stack = new Stack<int>();
            minStack = new Stack<int>();
        }

        public void Push(int val)
        {
            stack.Push(val);
            if (minStack.Count == 0 || val <= minStack.Peek())
            {
                minStack.Push(val);
            }
        }

        public void Pop()
        {
            if (stack.Count > 0 && minStack.Peek() == stack.Peek())
            {
                stack.Pop();
                minStack.Pop();
                return;
            }
            stack.Pop();
        }

        public int Top()
        {
            return stack.Peek();
        }

        public int GetMin()
        {
            return minStack.Peek();
        }
        public void Print()
        {
            Console.Write("Stack: ");
            foreach (var item in stack)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.Write("MinStack: ");
            foreach (var item in minStack)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}