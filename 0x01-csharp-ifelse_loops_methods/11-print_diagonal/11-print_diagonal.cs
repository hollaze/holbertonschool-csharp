using System;

class Line
{
        public static void PrintDiagonal(int length)
        {
                for (int i = 0; i < length; i++)
                {
                        for (int reach = 0; reach <= i; reach++)
                        {
                                if (reach == i)
                                        Console.WriteLine('\\');
                                else
                                        Console.Write(' ');
                        }

                }

                Console.WriteLine();
        }
}
