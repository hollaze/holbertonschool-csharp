using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        Dictionary<string, string> newDict = new Dictionary<string, string>();

        foreach (KeyValuePair<string, string> kv in myDict.OrderBy(key => key.Key))
        {
            Console.WriteLine("{0}: {1}", kv.Key, kv.Value);
        }
    }
}
