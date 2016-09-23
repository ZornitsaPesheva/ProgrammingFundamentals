using System;

namespace _16.Comparing_Floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
           // double eps = 0.000001;
            Console.WriteLine(Math.Abs((int)(n1 * 1000000) - (int)(n2 * 1000000)) < 1);
        }
    }
}
