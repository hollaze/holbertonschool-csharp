using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int count = 0;

        foreach (int value in myLList)
        {
            if (count == n)
                return (value);
            count++;
        }
        return (0);
    }
}
