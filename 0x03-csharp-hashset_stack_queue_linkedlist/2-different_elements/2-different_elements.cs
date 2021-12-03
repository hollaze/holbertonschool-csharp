using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> differentValues = new List<int> ();
        
        // Values only in list1
        foreach (int value in list1)
        {
            if (!list2.Contains(value))
                differentValues.Add(value);
        }
        // Values only in list2
        foreach (int value in list2)
        {
            if (!list1.Contains(value))
                differentValues.Add(value);
        }

        differentValues.Sort();   
        return differentValues;
    }
}