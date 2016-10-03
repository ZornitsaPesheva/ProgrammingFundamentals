using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> nums =
                Console.ReadLine().Split(' ')
                .Select(decimal.Parse).ToList();
            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i - 1] == nums[i])
                {
                    nums[i - 1] += nums[i];
                    nums.RemoveAt(i);
                    i = i - 2;
                    if (i < 0)
                    {
                        i = 0;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
