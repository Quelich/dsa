using System;
using SOLs;
using SOLs.QArray;
using SOLs.HashTable;

namespace SOLs
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            var sol = new RotateArray();
            sol.Rotate(new int[] { 1,2,3,4,5,6,7},3);  
            //System.Console.WriteLine(result);
        }
    }
}
