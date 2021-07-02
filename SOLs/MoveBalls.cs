using System;
using System.Collections.Generic;
using System.Linq;

namespace SOLs
{
    //Leetcode Problems: 1769
    public class MoveBalls
    {
        public static void Main(string[] args)
        {
            var boxes = "110";
            MinOperations(boxes);
        }
        public static int[] MinOperations(string boxes)
        {
            var ballLocations = new List<int>();
            int[] answer = new int[boxes.Length];
            var currentLocation = 0;
            foreach (var binary in boxes)
            {
                if (binary == '1')
                {
                    ballLocations.Add(currentLocation);
                }
                currentLocation++;
            }

            for (var i = 0; i < boxes.Length; i++)
            {
                var sum = ballLocations.Sum(location => Math.Abs(location - i));
                answer[i] = sum;
            }

            Console.WriteLine("Ball locations: ");
            Print(ballLocations);
            Console.WriteLine("\nAnswer: ");
            Print(answer);
            return answer;
        }
        private static void Print(int[] array)
        {
            foreach (var x in array)
            {
                Console.Write(x + " ");
            }
        }
        private static void Print(List<int> array)
        {
            foreach (var x in array)
            {
                Console.Write(x + " ");
            }
        }
    }
}