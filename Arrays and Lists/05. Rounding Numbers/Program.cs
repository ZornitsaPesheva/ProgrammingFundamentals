using System;
using System.Linq;

namespace _05.Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] nums = Console.ReadLine().Split(' ').
                Select(decimal.Parse).ToArray();

            foreach (var num in nums)
            {
                decimal rounded = Math.Round(num, MidpointRounding.AwayFromZero);
                Console.WriteLine(num + " => " + rounded);
            }
        }
    }
}
