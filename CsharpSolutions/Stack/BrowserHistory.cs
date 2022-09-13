using System;
using System.Collections.Generic;

namespace SOLs.Stack
{
    public class BrowserHistory
    {
        private LinkedList<string> history;
        private LinkedListNode<string> CurrentUrl;
        public BrowserHistory(string homepage)
        {
            history = new LinkedList<string>();
            history.AddFirst(homepage);
            CurrentUrl = history.First;
        }
        public void Visit(string url)
        {
            history.AddLast(url);
            var head = CurrentUrl;
            CurrentUrl = history.Last;
        }

        public string Back(int steps)
        {
            if (steps < 1)
                throw new ArgumentException("Steps cannot be less than 1!");
            if (steps > history.Count)
                steps = history.Count;
            for (var i = 0; i < steps; i++)
            {
                if (CurrentUrl.Previous != null)
                {
                    CurrentUrl = CurrentUrl.Previous;
                }
            }
            history.AddLast(CurrentUrl.Value);
            return CurrentUrl.Value;
        }

        public string Forward(int steps)
        {
            if (steps < 1)
                throw new ArgumentException("Steps cannot be less than 1!");
            if (steps > history.Count)
                steps = history.Count;
            for (var i = 0; i < steps; i++)
            {
                if (CurrentUrl.Next != null)
                {
                    CurrentUrl = CurrentUrl.Next;
                }
            }
            history.AddLast(CurrentUrl.Value);
            return CurrentUrl.Value;
        }

        public LinkedListNode<string> GetCurrentUrl()
        {
            return CurrentUrl;
        }

        public void PrintNodes()
        {
            foreach (var node in history)
            {
                Console.Write(node + "->");
            }
            System.Console.WriteLine();
        }
    }
}