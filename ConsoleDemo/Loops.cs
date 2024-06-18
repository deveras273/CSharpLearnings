using System;
using System.Net;

namespace ConsoleDemo
{
    class Loops
    {
        public static void Main()
        {
            for (int i =0; i< 10; i++)
            {
                if ( i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine($"We have hit a break statement");

            for ( int i = 0; i < 5; i++)
            {
                if (i == 3)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            Console.WriteLine("One");
            goto test;
            Console.WriteLine("Two");
            Console.WriteLine("Three");
            Console.WriteLine("Four");
        test:
            Console.WriteLine("Used the goto statement to come here");

            int a = 1;
            while (a < 4)
            {
                Console.WriteLine(a);
                a += 1;
            }

            int b = 7;
            do
            {
                Console.WriteLine(b);
                b -= 1; 
            }
            while (b >= -1);
        }
    }
}