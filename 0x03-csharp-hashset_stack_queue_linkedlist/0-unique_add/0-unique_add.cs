using System;
using System.Collections.Generic;

// Weird code

class List
{
    public static int Sum(List<int> myList)
    {
        int sum = 0;

        myList.Sort();

        for (int i = 0; i < myList.Count; i++)
        {
            if (i < myList.Count - 1)
                if (myList[i] != myList[i + 1])
                    sum += myList[i];
        }
        sum += myList[myList.Count - 1];
        return (sum);
    }
}
