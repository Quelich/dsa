using System.Collections.Generic;

namespace SOLs
{
    public class CountItem
    {
        public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue) {
            var counter = 0;
            foreach(var item in items)
            {
                if(ruleKey == "type")
                {
                    if(item[0] == ruleValue)
                    {
                        counter++;
                    } 
                }
                if(ruleKey == "color")
                {
                    if(item[1] == ruleValue)
                    {
                        counter++;
                    } 
                }
                if(ruleKey == "name")
                {
                    if(item[2] == ruleValue)
                    {
                        counter++;
                    } 
                }
            }
            return counter;
        }
    }
}