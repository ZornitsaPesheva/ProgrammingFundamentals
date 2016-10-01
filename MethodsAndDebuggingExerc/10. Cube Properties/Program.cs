using System;

namespace _10.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string lengthOf = Console.ReadLine();
            
            switch (lengthOf)
            {
                case "face":
                    Console.WriteLine($"{Math.Round(FaceDiag(side), 2):f2}");
                    break;
                case "space":
                    Console.WriteLine($"{Math.Round(SpaceDiag(side), 2):f2}");
                    break;
                case "volume":
                    Console.WriteLine($"{Math.Round(Volume(side), 2):f2}");
                    break;
                case "area":
                    Console.WriteLine($"{Math.Round(Area(side), 2):f2}");
                    break;
            }
        }

        private static double FaceDiag(double side)
        {
            return Math.Sqrt(2 * (side * side));
        }

        private static double SpaceDiag(double side)
        {
            return Math.Sqrt(3 * (side * side));
        }

        private static double Volume(double side)
        {
            return side * side * side;
        }

        private static double Area(double side)
        {
            return side * side * 6;
        }
    }
}
