using System;
using System.Collections.Generic;
using System.Linq;

namespace _15.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToList();
            List<int> newNumbers = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                int reversed = int.Parse(Reverce(numbers[i]));
                newNumbers.Add(reversed);
            }
            var sum = 0;
            foreach (var num in newNumbers)
            {
                sum += num;
            }
            Console.WriteLine(sum);
        }

        private static string Reverce(int v)
        {
            char[] charArray = v.ToString().ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
            
        }
    }
}
