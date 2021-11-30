using System;

class Program
{
        static void Main(string[] args)
        {
                Random rndm = new Random();
                int number = rndm.Next(-10000, 10000);
                int last_digit = number % 10;
                string str = string.Format("The last digit of {0} is {1} and is ", number, last_digit);

                if (last_digit > 5)
                        Console.WriteLine(str + "greater than 5");
				if (last_digit == 0)
                        Console.WriteLine(str + "0");
				if (last_digit < 6 && last_digit != 0)
                        Console.WriteLine(str + "less than 6 and not 0");
        }
}
