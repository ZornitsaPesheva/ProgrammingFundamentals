using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(' ');
            List<int> nums = strings.Select(int.Parse).ToList();

            var sortedNums = nums.OrderByDescending(x => x);
            var largesNums = sortedNums.Take(3);
            Console.WriteLine(string.Join(" ", largesNums));
        }
    }
}
