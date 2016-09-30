using System;

namespace _09.Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            double line1 = GetDistance(x2, y2, x1, y1);
            double line2 = GetDistance(x4, y4, x3, y3);

            if (line1 >= line2)
            {
                double x1y1ToCenter = GetDistance(x1, y1, 0, 0);
                double x2y2ToCenter = GetDistance(x2, y2, 0, 0);
                if (x1y1ToCenter <= x2y2ToCenter)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                double x3y3ToCenter = GetDistance(x3, y3, 0, 0);
                double x4y4ToCenter = GetDistance(x4, y4, 0, 0);
                if (x3y3ToCenter <= x4y4ToCenter)
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }

        static double GetDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return distance;
        }
    }
}
