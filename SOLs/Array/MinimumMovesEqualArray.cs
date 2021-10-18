using SOLs.Array;
namespace SOLs.Array {
    //Leetcode Problems: 462
    public class MinimumMovesEqualArray {

        private delegate int ToAbs (int val1, int val2);
        public int MinMoves2 (int[] nums) {
            //Sorting nums
            System.Array.Sort (nums);
            var newNums = new int[nums.Length];
            for (var i = 0; i < nums.Length; i++) {
                newNums[i] = nums[i];
            }

            var median = nums[nums.Length / 2];
            var result = 0;
            //Anonymous method to calculate absolute value between the numbers, which is the distance 
            ToAbs getAbs = delegate (int val1, int val2) {

                if (val1 - val2 < 0) {
                    return (val1 - val2) * -1;
                }

                return val1 - val2;
            };
            //Calculating the moves
            foreach (var num in nums) {
                //distance = toAbs(avg, num);
                result += getAbs (median, num);
            }
            return result;
        }
    }
}