using System;

namespace SOLs
{
    public class QueryCirclePoint
    {
        // public static void Main(string[] args)
        // {
        //     int[][] points = new int[4][];
        //     int[][] queries = new int[3][];
        //     points[0] = new int[] {1, 3};
        //     points[1] = new int[] {3, 3};
        //     points[2] = new int[] {5, 3};
        //     points[3] = new int[] {2, 2};
        //     queries[0] = new int[] {2,3,1 };
        //     queries[1] = new int[] {4,3,1 };
        //     queries[2] = new int[] {1,1,2 };
        //     Print(CountPoints(points, queries));
        // }
        public static int[] CountPoints(int[][] points, int[][] queries)
        {
            int[] result = new int[queries.Length];
            var counter = 0;
            var i = 0;
            foreach (var query in queries)
            {
                foreach (var point in points)
                {
                    var distance = Math.Sqrt(Math.Pow(point[0] - query[0],2) + Math.Pow(point[1] - query[1],2));
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

        private static void Print(int[] array)
        {
            foreach (var x in array)
            {
                Console.Write(x + " ");
            }
        }
    }
}