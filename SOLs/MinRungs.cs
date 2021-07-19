namespace SOLs
{
    public class MinRungs
    {
        public class Solution {
            public int AddRungs(int[] rungs, int dist) {
                var currDist = 0;
                var addRung = 0;
                var i = 0;
                while(i < rungs.Length)
                {
                    if(i < rungs.Length - 1) // if not the last iteration
                    {
                        if(i == 0)
                        {
                            if(dist < rungs[i])
                            {
                                var tempDist = dist;
                                while(tempDist < rungs[i])
                                {
                           
                                }
                            }
                        }
                        currDist = rungs[i+1] - rungs[i];
                        if(currDist > dist)
                        {
                            addRung += (int)(currDist / dist);
                        }
                    }
                    i++;
                }
                return addRung;
            }
        }
    }
}