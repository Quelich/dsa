namespace Quelich.DataStructures;

internal class Program
{
    static void Main()
    {
        int[] arr = new[] { -21, 0, 10, 42, 50, 67, 82, 145 };
        int x = 82;
        var binarySearch = new SearchAlgorithms();

        int r = binarySearch.BinarySearch(arr, x);
        
    }
}
