using System;

namespace _5.Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double trBase = double.Parse(Console.ReadLine());
            double trHeight = double.Parse(Console.ReadLine());
            double area = triangleArea(trBase, trHeight);
            Console.WriteLine(area);
        }

        static double triangleArea(double trBase, double trHeight)
        {
            return trBase * trHeight / 2;
        }
    }
}
