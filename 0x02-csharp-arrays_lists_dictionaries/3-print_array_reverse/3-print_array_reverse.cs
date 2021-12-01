using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array == null || array.Length == 0)
            Console.WriteLine();
        else
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(i > 0 ? "{0} " : "{0}\n", array[i]);
            }
        }
    }
}
