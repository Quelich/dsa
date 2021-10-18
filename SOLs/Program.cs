using System;
using SOLs;
using SOLs.Array;


namespace SOLs
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            var sol = new ReplaceElementsRightSide();
            var result = sol.ReplaceElements(new[]{400});
            System.Console.WriteLine(string.Join(",", result));
        }
    }
}
