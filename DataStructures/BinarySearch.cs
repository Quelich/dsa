using System.Diagnostics;

namespace Quelich.DataStructures;

public class SearchAlgorithms
{
    public int BinarySearch(int[] arr, int x)
    {
        int lower,
            upper,
            mid;

        lower = 0;
        upper = arr.Length - 1;

        Stopwatch sw = Stopwatch.StartNew();
        sw.Start();
        while (lower != upper)
        {
            mid = (lower + upper) / 2;
            if (arr[mid] == x)
            {
                sw.Stop();
                TimeSpan ts = sw.Elapsed;
                System.Console.WriteLine("Found at index #{0} in {1}ms", mid, ts.Milliseconds);
                return mid;
            }
            else if (x > arr[mid])
            {
                lower = mid + 1;
            }
            else
            {
                upper = mid - 1;
            }
        }

        return -1;
    }
}
