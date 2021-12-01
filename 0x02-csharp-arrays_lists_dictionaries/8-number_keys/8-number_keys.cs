using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int keyNumber = 0;

        foreach (string key in myDict.Keys)
            keyNumber += 1;

        return (keyNumber);
    }
}
