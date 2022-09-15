using System.Collections.Generic;

namespace Quelich.DataStructures;

class QString
{
    // Implement an algorithm to determine if a string has all unique characters.
    public bool IsUnique(string str)
    {
        int i;
        char c;
        var map = new Dictionary<int, char>();

        for (i = 0; i < str.Length; i++)
        {
            c = str[i];

            if (!map.ContainsValue(c))
            {
                map[i] = c;
            }
            else
            {
                return false;
            }
        }
        return true;
    }

    public bool IsUniqueWithoutMap(string str)
    {
        int i,
            j;

        for (i = 0; i < str.Length; i++)
        {
            for (j = i + 1; j < str.Length; j++)
            {
                if (str[i] == str[j])
                {
                    return false;
                }
            }
        }
        return true;
    }

    public string CompressString(string str)
    {
        int i,
            counter;
        str.ToLower();
        var map = new Dictionary<int, char>();
        string compressedStr = string.Empty;

        map[0] = str[0];
        compressedStr += str[0].ToString();
        counter = 0;
        for (i = 0; i < str.Length; i++)
        {
            char c = str[i];
            if (!map.ContainsValue(c))
            {
                map.Clear();
                map[i] = c;
                compressedStr += counter.ToString();
                compressedStr += c.ToString();
                counter = 1;
            }
            else
            {
                counter++;
            }
        }
        compressedStr += counter.ToString();
        return compressedStr;
    }
}
