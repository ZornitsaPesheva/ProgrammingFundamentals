using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers =
                Console.ReadLine().Split(' ').ToList();

            int currentStart = 0;
            int currentLenght = 1;
            int longestStart = 0;
            int longestLenght = 1;
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentLenght++;
                    if (currentLenght > longestLenght)
                    {
                        longestLenght = currentLenght;
                        longestStart = currentStart;
                    }
                }
                else
                {
                    currentStart = i;
                    currentLenght = 1;
                }
            }

            List<string> result = new List<string>();
            for (int i = longestStart; i < longestStart + longestLenght; i++)
            {
                result.Add(numbers[i]);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
