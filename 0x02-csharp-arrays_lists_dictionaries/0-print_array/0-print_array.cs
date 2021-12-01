using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        int[] array;

        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return (null);
        }

        array = new int[size];

        if (size == 0)
            Console.WriteLine();

        for (int i = 0; i < size; i++)
        {
            Console.Write((i < size - 1) ? $"{i} " : $"{i}\n");
        }

        return (array);
    }
}
