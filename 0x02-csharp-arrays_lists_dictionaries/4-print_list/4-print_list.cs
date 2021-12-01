using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        List<int> values;

        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return (null);
        }

        values = new List<int>(size);

        if (size == 0)
            Console.WriteLine();

        for (int i = 0; i < size; i++)
        {
            Console.Write((i < size - 1) ? $"{i} " : $"{i}\n");
            values.Add(i);
        }

        return (values);
    }
}
