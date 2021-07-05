using System;

namespace SOLs
{
    //Leetcode Problems: 1720 INCOMPLETE
    public class DecodeXORed
    {
        // public static void Main(string[] args)
        // {
        //     
        //     var util = new ArrayUtils();
        //     var encoded = new int[] { 1,2,3};
        //     var first = 1;
        //     util.Print(Decode(encoded, first));
        //
        // }
        public static int[] Decode(int[] encoded, int first)
        {
            var arr = new int[encoded.Length + 1];
            arr[0] = first;
            var val = 0;
            var j = 0;
            for (var i = 1; i < encoded.Length; i++)
            {
                val ^= arr[i];
                if (val == encoded[j])
                {
                    arr[i + 1] = val;
                }
                j++;
            }
            return arr;
        }   
    }
}