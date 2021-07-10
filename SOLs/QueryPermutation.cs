using System.Collections.Generic;
using System.Linq;

namespace SOLs
{
    public class QueryPermutation
    {
        // public static void Main(string[] args)
        // {
        //     ProcessQueries(new[] {3, 1, 2, 1}, 5);
        // }

        public static int[] ProcessQueries(int[] queries, int m)
        {
            var p = new int[m];
            var length = 0;
            var elements = new List<int>();
            var result = new int[queries.Length];
            //Initialising 'p'
            for(var i = 1; i<=m; i++)
            {
                p[length] = i;
                length++;
            }
            // 1 2 3 4 5 0
            for(var i = 0; i<queries.Length; i++)
            {
                for(var j = 0; j<p.Length; j++)
                {
                    if (p[j] != queries[i]) continue;
                    //deleting the element at the j
                    for (var k = j+1; j<length; j++)
                    {
                        p[k - 1] = p[k];
                    }
                    length--;
                    //Inserting p[j] to p[0]
                    
                }
            }
            var util = new ArrayUtils();
            util.Print(result);
            return null;
        }
    }
}