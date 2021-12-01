using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> divBy2 = new List<bool>(myList.Count);

        foreach (var value in myList)
        {
            if (value % 2 == 0)
                divBy2.Add(true);
            else
                divBy2.Add(false);
        }

        return (divBy2);
    }
}
