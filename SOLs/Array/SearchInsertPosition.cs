
namespace SOLs.Array
{
    //Leetcode problems: 35 
    public class SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            var result = new int[nums.Length + 1];
            for (var i = 0; i < nums.Length; i++)
            {
                result[i] = nums[i];
            }
            result[^1] = target;
            System.Array.Sort(result);
            for (var i = 0; i < result.Length + 1; i++)
            {
                if (i < result.Length && nums[i] == target) return i;
                if (result[i] == target) return i;
            }
            return System.Array.IndexOf(result, target);
        }
    }
}