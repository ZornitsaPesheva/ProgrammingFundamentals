using System;
using System.Linq;

namespace _11.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().
                Split(' ').Select(int.Parse).ToArray();

            int index = 0;
            bool found = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0 && array.Length == 1)
                {
                    index = 0;
                    found = true;
                }
                else
                {
                    int leftSum = 0;
                    int rightSun = 0;
                    for (int j = 0; j < i; j++)
                    {
                        leftSum += array[j];
                    }
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        rightSun += array[j];
                    }
                    if (leftSum == rightSun)
                    {
                        index = i;
                        found = true;
                    }
                }

            }
            if (found || array.Length == 0)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
