namespace SOLs.QArray
{
    // Leetcode 75
    public class SortColors {
    public void Sort(int[] nums) {
        // red 0 white 1 blue 2
         for (var gap = nums.Length / 2; gap > 0; gap /= 2) {
                for (var i = gap; i < nums.Length;i++) {
                    var newElement = nums[i];
                    var j = i;
                    while (j >= gap && nums[j - gap] > newElement) {
                        nums[j] = nums[j - gap];
                        j -= gap;
                    }
                    nums[j] = newElement;
                }
            }
    }
}
}