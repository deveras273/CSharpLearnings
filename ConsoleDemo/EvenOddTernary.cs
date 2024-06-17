using System;

namespace ConsoleDemo
{
    class EvenOddTernary
    {
        static void Main()
        {
            Console.WriteLine("Enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The given number is {(a % 2 == 0 ? "Even" : "Odd")}");
        }
    }
}