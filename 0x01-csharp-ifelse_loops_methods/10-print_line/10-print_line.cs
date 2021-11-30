using System;

class Line
{
        public static void PrintLine(int length)
        {
                int i = 0;
                while (i < length)
                {
                        Console.Write("_");
                        i++;
                }
                Console.WriteLine();
        }
}
