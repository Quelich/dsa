using System;
using System.Diagnostics.CodeAnalysis;

namespace SOLs.QArray
{
    public class SubrectangleQueries
    {
        private int[][] Rectangle { get; }
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
}