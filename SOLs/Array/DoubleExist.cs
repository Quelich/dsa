using System.Collections.Generic;
namespace SOLs.QArray
{
    public class DoubleExist
    {
        public bool CheckIfExist(int[] arr)
        {
            var set = new HashSet<int>();
            foreach (var item in arr)
            {

                if (set.Contains(2 * item))
                    return true;
                if (item % 2 == 0 && set.Contains(item / 2))
                    return true;
                else
                    set.Add(item);
            }
            return false;
        }
    }
}