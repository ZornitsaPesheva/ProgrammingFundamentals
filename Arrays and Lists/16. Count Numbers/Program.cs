using System;
using System.Collections.Generic;
using System.Linq;

namespace _16.Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> nums = Console.ReadLine().Split(' ')
                .Select(decimal.Parse).ToList();

            Dictionary<decimal, decimal> counts = new Dictionary<decimal, decimal>();
            foreach (decimal num in nums)
            {
                if (counts.ContainsKey(num))
                {
                    counts[num]++;
                }
                else
                {
                    counts[num] = 1;
                }
            }
            foreach (decimal i in counts.Keys.OrderBy(x => x))
            {
                Console.WriteLine($"{i} -> {counts[i]}");
            }

        }
    }
}
