using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
                        for (int i = 0; i < 100; i++)
                                Console.Write(string.Format((i != 99) ? "{0:D2}, " : "{0:D2}\n", i));
                }
    }
}
