using System;
using SOLs;
using SOLs.QArray;


namespace SOLs
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            var sol = new MoveZeros();
            var result = sol.Move(new int[] { 0, 1, 0, 3, 12 });
            System.Console.WriteLine(string.Join(",", result));
        }
    }
}
