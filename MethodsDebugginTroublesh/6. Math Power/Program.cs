using System;

namespace _6.Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            double result = RaiseToPower(n, p);
            Console.WriteLine(result);
        }

        static double RaiseToPower(double n, int p)
        {
            double result = 1;
            for (int i = 1; i <= p; i++)
            {
                result = result * n;
            }
            return result;
        }
    }
}
