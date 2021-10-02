using System;
using System.Collections.Generic;

public class BrowserHistory
{
    private LinkedList<string> history;
    private Stack<string> BackStack;
    private Stack<string> ForwardStack;
    private LinkedListNode<string> CurrentUrl;
    public BrowserHistory(string homepage)
    {
        history = new LinkedList<string>();
        BackStack = new Stack<string>();
        ForwardStack = new Stack<string>();
        history.AddFirst(homepage);
        CurrentUrl = history.First;
    }
    public void Visit(string url)
    {
        history.AddLast(url);
        BackStack.Clear();
        ForwardStack.Clear();
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
                if (BackStack.Count == 0)
                {
                    BackStack.Push(CurrentUrl.Value);
                    CurrentUrl = CurrentUrl.Previous;
                }
                else
                {
                    BackStack.Push(CurrentUrl.Value);
                    CurrentUrl = CurrentUrl.Previous;
                }
            }
        }
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
                if (ForwardStack.Count == 0)
                {
                    ForwardStack.Push(CurrentUrl.Value);
                    CurrentUrl = CurrentUrl.Next;
                }
                else
                {
                    ForwardStack.Push(CurrentUrl.Value);
                    CurrentUrl = CurrentUrl.Next;
                }
            }
        }
        return CurrentUrl.Value;
    }

    public LinkedListNode<string> GetCurrentUrl()
    {
        return CurrentUrl;
    }
}

internal class Program
{
    public static void Main(string[] args)
    {
        BrowserHistory browserHistory = new BrowserHistory("leetcode.com");
        browserHistory.Visit("google.com");       // You are in "leetcode.com". Visit "google.com"
        browserHistory.Visit("facebook.com");     // You are in "google.com". Visit "facebook.com"
        browserHistory.Visit("youtube.com");      // You are in "facebook.com". Visit "youtube.com"
        browserHistory.Back(1);                   // You are in "youtube.com", move Back to "facebook.com" return "facebook.com"
        Console.WriteLine(browserHistory.GetCurrentUrl().Value);
        browserHistory.Back(1);                   // You are in "facebook.com", move Back to "google.com" return "google.com"
        Console.WriteLine(browserHistory.GetCurrentUrl().Value);
        browserHistory.Forward(1);                // You are in "google.com", move Forward to "facebook.com" return "facebook.com"
        Console.WriteLine(browserHistory.GetCurrentUrl().Value);
        browserHistory.Visit("linkedin.com");     // You are in "facebook.com". Visit "linkedin.com"
        browserHistory.Forward(2);                // You are in "linkedin.com", you cannot move Forward any steps.
        Console.WriteLine(browserHistory.GetCurrentUrl().Value);
        browserHistory.Back(2);                   // You are in "linkedin.com", move Back two steps to "facebook.com" then to "google.com". return "google.com"
        Console.WriteLine(browserHistory.GetCurrentUrl().Value);
        browserHistory.Back(7);                   // You are in "google.com", you can move Back only one step to "leetcode.com". return "leetcode.com"
        Console.WriteLine(browserHistory.GetCurrentUrl().Value);
    }
}