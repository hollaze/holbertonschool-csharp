using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value)
    {
        // Replace value if key exists
        if (myDict.ContainsKey(key))
        {
            myDict[key] = value;
            return (myDict);
        }

        // create key value pair
        myDict.Add(key, value);
        return (myDict);
    }
}
