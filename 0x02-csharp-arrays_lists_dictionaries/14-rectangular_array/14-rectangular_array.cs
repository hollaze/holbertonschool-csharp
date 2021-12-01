using System;


class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (i == 2 && j == 2)
                    Console.Write("1 ");
                else
                    Console.Write(j == 4 ? "0" : "0 ");
            }
            Console.WriteLine();
        }
    }
}
