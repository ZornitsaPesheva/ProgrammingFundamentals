using System;
using System.Linq;

namespace _02.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().
                Split(' ').Select(int.Parse).ToArray();

            int k = int.Parse(Console.ReadLine());

            int[] rotated = new int[array.Length];
            int[] sum = new int[array.Length];

            rotated = Rotate(array);
            for (int i = 1; i <= k; i++)
            {
                Add(rotated, sum);
                rotated = Rotate(rotated);             
            }

            Console.WriteLine(string.Join(" ", sum));
        }

        private static void Add(int[] rotated, int[] sum)
        {
            for (int i = 0; i < rotated.Length; i++)
            {
                sum[i] += rotated[i];
            }
        }

        private static int[] Rotate(int[] array)
        {
            int[] rotated = new int[array.Length];
            rotated[0] = array[array.Length - 1];
            for (int i = 1; i < array.Length; i++)
            {
                rotated[i] = array[i - 1];
            }
            return rotated;
        }
    }
}
