using System;
using System.Linq;

namespace _08.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().
                Split(' ').Select(int.Parse).ToArray();

            int[] counts = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] == array[i])
                    {
                        count++;
                    }
                }
                counts[i] = count;
            }

            int maxIndex = FindMaxIndex(counts);

            Console.WriteLine(array[maxIndex]);
        }

        private static int FindMaxIndex(int[] array)
        {
            int max = array[0];
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxIndex = i;
                }            
            }
            return maxIndex;           
        }
    }
}
