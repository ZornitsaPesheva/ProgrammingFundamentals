using System;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figType = Console.ReadLine();
            double par1 = 0;
            double par2 = 0;

            par1 = double.Parse(Console.ReadLine());
            if (figType == "triangle" || figType == "rectangle")
            {      
                par2 = double.Parse(Console.ReadLine());
            }
            if (figType == "triangle")
            {
                par2 /= 2;
            }
            else if (figType == "circle")
            {
                par2 = Math.PI;
                par1 *= par1;
            }
            else if (figType == "square")
            {
                par2 = par1;
            }
            Console.WriteLine($"{Math.Round(Area(par1, par2), 2)}");
        }

        private static double Area(double par1, double par2)
        {
            return par1 * par2; 
        }
    }
}
