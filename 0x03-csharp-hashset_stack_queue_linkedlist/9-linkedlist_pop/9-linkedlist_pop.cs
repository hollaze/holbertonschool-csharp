using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        foreach (int nodeValue in myLList)
        {
            myLList.RemoveFirst();
            return (nodeValue);
        }

        return (0);
    }
}
