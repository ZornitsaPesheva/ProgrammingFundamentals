using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToArray();

            List<int> list = new List<int>();

            foreach (int num in nums)
            {
                if (num >= 0)
                {
                    list.Add(num);
                }
            }
            list.Reverse();
            if (list.Count() != 0)
            {
                Console.WriteLine(string.Join(" ", list));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
