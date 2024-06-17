using System;
using System.Runtime.InteropServices;

namespace ConsoleDemo
{
    class Addition
    {
        static void Main()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The addition of the input of two numbers is {a + b}");
        }
    }
}