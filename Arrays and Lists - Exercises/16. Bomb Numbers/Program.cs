using System;
using System.Collections.Generic;
using System.Linq;

namespace _16.Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers =
                Console.ReadLine().Split(' ')
                .Select(int.Parse).ToList();
            int[] bomb = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb[0])
                {
                    int left = Math.Max(i - bomb[1], 0);
                    int right = Math.Min(i + bomb[1], numbers.Count - 1);
                    int lenght = right - left + 1;
                    numbers.RemoveRange(left, lenght);
                    i = 0;
                }
            }
            int sum = numbers.Sum();
            Console.WriteLine(sum);
        }
    }
}
