using System;
namespace SOLs.Array
{
    public class ReplaceElementsRightSide
    {
        public int[] ReplaceElements(int[] arr)
        {

            var max = arr[arr.Length - 1]; // 1
            var prev = 0;
            for (var i = arr.Length - 1; i > 0; i--)
            {
                prev = arr[i - 1];
                arr[i - 1] = max;
                if (prev >= max)
                {
                    max = prev;
                }
            }
            arr[arr.Length - 1] = -1;
            return arr;
        }
    }
}