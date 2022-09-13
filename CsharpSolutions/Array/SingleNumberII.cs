using System.Collections.Generic;
namespace SOLs.QArray {
    public class SingleNumberII {
        public int SingleNumber (int[] nums) {
            var ones = 0;
            var twos = 0;
            var commonBitMask = 0;
            for (var i = 0; i < nums.Length; i++) {
                twos |= (ones & nums[i]);
                ones ^= nums[i];
                commonBitMask = ~(ones & twos);
                ones &= commonBitMask;
                twos &= commonBitMask;
                System.Console.WriteLine("i: {0}, ones: {1}, twos: {2}, commonBitMask: {3}", i, ones, twos, commonBitMask);
            }
            return ones;
        }
    }
}