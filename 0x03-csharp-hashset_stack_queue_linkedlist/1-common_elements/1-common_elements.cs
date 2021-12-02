using System;
using System.Collections.Generic;


class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> newList = new List<int>();

        foreach (int value in list1)
        {
            foreach (int v in list2)
            {
                if (!newList.Contains(value) && !newList.Contains(v) && v == value)
                    newList.Add(v);
            }
        }

        newList.Sort();

        return (newList);
    }
}
