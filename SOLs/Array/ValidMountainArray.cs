namespace SOLs.QArray
{
    // Leetcode #941
    public class ValidMountainArray
    {
        public bool IsMountain(int[] arr)
        {
            if (arr.Length < 3) return false;
            if ((arr[0] > arr[1])) return false;
            var both = false;
            for (var i = 0; i < arr.Length - 1; i++)
            {
                if (!(arr[i] < arr[i + 1])) // non-increasing
                {
                    for (var j = i; j < arr.Length - 1; j++)
                    {
                        if (!(arr[j] > arr[j + 1])) // non-decreasing
                        {
                            return false;
                        }
                        both = true;
                    }
                }
            }
            return both;
        }
    }
}