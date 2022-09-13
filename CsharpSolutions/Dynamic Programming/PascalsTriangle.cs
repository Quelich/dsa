using System;
using System.Collections.Generic;

namespace SOLs.DP
{
    class PascalsTriangle
    {
        public static IList<IList<int>> Generate(int numRows)
        {
            var pascalsTriangle = new List<IList<int>>();
            // First row
            pascalsTriangle.Add(new List<int>() { 1 });
            for (int row = 1; row < numRows; row++)
            {
                var currRow = new List<int>();
                // Dynamic programming as using the previous row
                var prevRow = pascalsTriangle[row - 1];
                // First column of any row is 1
                currRow.Add(1);
                // Inner columns
                for (int col = 1; col < row; col++)
                {
                    currRow.Add(prevRow[col - 1] + prevRow[col]);
                }
                // Last column of any row is 1
                currRow.Add(1);
                // Add current row to pascalsTriangle
                pascalsTriangle.Add(currRow);
            }
            return pascalsTriangle;
        }
    }
}