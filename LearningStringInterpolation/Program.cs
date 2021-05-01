using System;

namespace LearningStringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = new { x = 1, y = 2 };
            Console.WriteLine("x" + point.x + "y" + point.y); // String Concatination
            Console.WriteLine("x {0} y {1}" + point.x , point.y); // String Formatting
            Console.WriteLine($"x {point.x} y {point.y}"); // String Formatting
        }
    }
}
