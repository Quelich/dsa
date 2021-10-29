using System;
using System.Collections;
using SOLs;

namespace SOLs.QArray
{
    public class HeightChecker
    {
        public int CheckHeights(int[] heights)
        {
            var counter = 0;
            var expected = new int[heights.Length]; 
            Array.Copy(heights,expected,heights.Length);
            Array.Sort(heights);
            for (var i = 0; i < heights.Length; i++)
            {
                if (heights[i] != expected[i])
                {
                    counter++;
                }
            }
            return counter;
        }
    }

}