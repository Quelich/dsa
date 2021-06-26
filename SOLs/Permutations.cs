using System.Collections.Generic;
namespace SOLs
{
    public class Permutations
    {
        // public static void Main(string[] args)
        // {
        //     int[] nums = {1,2,3};
        // }
        public IList<IList<int>> Permute(int[] nums)
        {

           
            
            for (var i = 0; i < nums.Length; i++)
            {
                var perm = new int[nums.Length - 1];
                perm[i] = i;
                for (var j = i; j < perm.Length; j++)
                {
                   
                    
                }
                
            }
            return null;
        }
        
    }
}   
