using System;
using System.Linq;

namespace _07.MaxSequenceOfIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().
                Split(' ').Select(int.Parse).ToArray();

            int currentStart = 0;
            int currentLenght = 1;
            int longestStart = 0;
            int longestLenght = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1])
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

            int[] result = new int[longestLenght];
            int j = 0;

            for (int i = longestStart; i < longestLenght + longestStart; i++)
            {
                result[j] = array[i];
                j++;
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
