using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ')
                .Select(double.Parse).ToArray();
            var counts = new SortedDictionary<double, int>();
            foreach (double num in numbers)
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

            foreach (double num in counts.Keys)
            {
                Console.WriteLine($"{num} -> {counts[num]}");
            }
            //Следващото решение е с лист:
            //Dictionary<double, int> counts = new Dictionary<double, int>();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (counts.ContainsKey(numbers[i]))
            //    {
            //        counts[numbers[i]]++;
            //    }
            //    else
            //    {
            //        counts.Add(numbers[i], 1);
            //    }
            //}
            //List<double> list = counts.Keys.ToList();
            //list.Sort();
            //foreach (double key in list)
            //{
            //    Console.WriteLine($"{key} -> {counts[key]}");
            //}
        }
    }
}
