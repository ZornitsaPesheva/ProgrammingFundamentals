using System;

namespace _10.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string lengthOf = Console.ReadLine();
            double result = 0;
            
            switch (lengthOf)
            {
                case "face":
                    result = Math.Sqrt(Calc(side, 2));
                    break;
                case "space":
                    result = Math.Sqrt(Calc(side, 3));
                    break;
                case "volume":
                    result = Calc(side, side);
                    break;
                case "area":
                    result = Calc(side, 6);
                    break;
            }
            Console.WriteLine($"{Math.Round(result, 2):f2}");
        }

        private static double Calc(double side, double x)
        {
            return x * (side * side);
        }
    }
}
