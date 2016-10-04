using System;
using System.Collections.Generic;
using System.Linq;

namespace _15.Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToList();
            List<int> squares = new List<int>();
            foreach (int num in nums)
            {
                if (Math.Sqrt(num) == (int)Math.Sqrt(num))
                {
                    squares.Add(num);
                }
            }
            squares.Sort();
            squares.Reverse();
            Console.WriteLine(string.Join(" ", squares));
        }
    }
}
