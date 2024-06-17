using System;

namespace ConsoleDemo
{
    class StringInterpolation
    {
        static void Main()
        {
            string name = "Sam";
            string course = "CSE";
            string institute = "Arizona State University";
            Console.WriteLine("The student " + name + " is enrolled in " + course + " at the following college " + institute);
            Console.WriteLine("The Student {0} is enrolled in {1} at the following college {2}", name, course, institute);
            Console.WriteLine($"The student {name} is enrolled in {course} at the following college {institute}");
        }
    }
}