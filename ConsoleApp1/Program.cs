using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 31;
            int b = 54;
            int c = 11;

            int odd = (a % 3 % 2 + b % 3 % 2 + c*2 % 3 % 2)/2;

            Console.WriteLine($" Результат {odd}");
        }
    }
}
