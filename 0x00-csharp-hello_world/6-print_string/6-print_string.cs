using System;

class Program
{
        static void Main(string[] args)
        {
                string str = "Holberton School";

                for (int i = 0; i < 3; i++)
                        Console.Write(str);
                Console.WriteLine();

                for (int i = 0; i < 9; i++)
                        Console.Write(str[i]);
                Console.WriteLine();

        }
}