using System;

namespace _12.Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double heighht = double.Parse(Console.ReadLine());
            double perimeter = width * 2 + heighht * 2;
            double area = width * heighht;
            double diagonal = Math.Sqrt(width * width + heighht * heighht);
            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}
