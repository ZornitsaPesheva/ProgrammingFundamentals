using System;

namespace _4.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            double courses = Math.Ceiling((double)n / (double)p);
            Console.WriteLine(courses);
        }
    }
}
