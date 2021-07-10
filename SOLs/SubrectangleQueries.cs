using System;
using System.Diagnostics.CodeAnalysis;

namespace SOLs
{
    public class SubrectangleQueries
    {
        private int[][] Rectangle { get;} 
         public SubrectangleQueries(int[][] rectangle)
         {
                 Rectangle = rectangle;
                //Displaying rectangle
                foreach (var t in Rectangle)
                {
                    foreach (var t1 in t)
                    {
                        Console.Write(t1 + " ");
                    }

                    Console.WriteLine();
                }
         }
            
            public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue)
            {
                //Implementing new value
                for (var i = row1; i <= row2; i++)
                {
                    
                    for (var j = col1; j <= col2; j++)
                    {
                        Rectangle[i][j] = newValue;
                    }
                }
                //Displaying new rectangle
                foreach (var t in Rectangle)
                {
                    foreach (var t1 in t)
                    {
                        Console.Write(t1 + " ");
                    }

                    Console.WriteLine();
                }
            }
            
            public int GetValue(int row, int col)
            {
                return Rectangle[row][col];
            }
    }

    // class Program
    // {
    //     // public static void Main(string[] args)
    //     // {
    //     //     int[][] jaggedArray = new int[4][];
    //     //     jaggedArray[0] = new int[] { 1,2,1};
    //     //     jaggedArray[1] = new int[] { 4,3,4};
    //     //     jaggedArray[2] = new int[] { 3,2,1};
    //     //     jaggedArray[3] = new int[] { 1,1,1};
    //     //     SubrectangleQueries subrectangleQueries = new SubrectangleQueries(jaggedArray);
    //     //     Console.WriteLine(subrectangleQueries.GetValue(0,2));
    //     //     subrectangleQueries.UpdateSubrectangle(0, 0, 3, 2, 5);
    //     //
    //     // }
    // }
}