using System.Collections.Generic;
using System.Diagnostics;

namespace Quelich.DataStructures;

internal class Program
{
    static void Main()
    {
        var msort = new MergeSortAlgorithm();

        int[] arr = new[] { 78, 68, 1, 452, 10, 96, 4645, -74 };

        Stopwatch sw = Stopwatch.StartNew();
        sw.Start();
        msort.MergeSort(arr, 0, arr.Length - 1);
        sw.Stop();
        TimeSpan ts = sw.Elapsed;
        System.Console.WriteLine("ExecutedMergeSort in {0}ms", ts.Milliseconds);
        System.Console.WriteLine("MergeSort: ");
        foreach (var i in arr)
        {
            System.Console.Write($" {i}");
        }
    }
}
