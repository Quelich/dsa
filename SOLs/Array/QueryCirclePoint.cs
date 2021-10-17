using System;

namespace SOLs.Array
{
    public class QueryCirclePoint
    {
        public static int[] CountPoints(int[][] points, int[][] queries)
        {
            int[] result = new int[queries.Length];
            var counter = 0;
            var i = 0;
            foreach (var query in queries)
            {
                foreach (var point in points)
                {
                    var distance = Math.Sqrt(Math.Pow(point[0] - query[0], 2) + Math.Pow(point[1] - query[1], 2));
                    if (distance <= query[2])
                    {
                        counter++;
                    }
                }
                result[i] = counter;
                counter = 0;
                i++;
            }
            return result;
        }
    }
}