using System;
using System.Collections.Generic;

namespace SOLs.Array
{
    public class RotateImage
    {
        public static void Rotate(int[,] matrix)
        {
            var j = 0;
            var result = new List<int[]>();
            //Getting elements into a list
            while (j != matrix.GetLength(1))
            {
                var k = 0;
                var temp = new int[matrix.GetLength(1)];
                for (var i = 0; i < matrix.GetLength(0); i++)
                {

                    temp[k] = matrix[i, j];
                    k++;
                    if (i == matrix.GetLength(0) - 1)
                    {
                        result.Add(temp);
                        j++;
                    }
                }
            }
            //Reversing each element(int[] array)
            foreach (var VARIABLE in result)
            {
                Array.Reverse(VARIABLE);
            }
            // Printing part
            Console.Write("[");
            var m = 0;
            foreach (var VARIABLE in result)
            {
                Console.Write("[");
                for (var i = 0; i < VARIABLE.Length; i++)
                {
                    Console.Write(VARIABLE[i]);
                    if (i != VARIABLE.Length - 1) Console.Write(",");
                }
                Console.Write("]");
                m++;
                if (m != result.Count) Console.Write(",");
            }
            Console.Write("]");
        }
    }

}