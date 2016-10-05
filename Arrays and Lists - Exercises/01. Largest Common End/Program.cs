using System;
using System.Linq;

namespace _01.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine().
                Split(' ').ToArray();
            string[] array2 = Console.ReadLine().
                Split(' ').ToArray();

            int leftCommonEnd = 0;
            int rightCommonEnd = 0;

            int minArrayLength = Math.Min(array1.Length, array2.Length);
            int maxArrayLength = Math.Max(array1.Length, array2.Length);
            int diff = maxArrayLength - minArrayLength;

            for (int i = 0; i < minArrayLength; i++)
            {
                if (array1[i] == array2[i])
                {
                    leftCommonEnd++;
                }
            }

            int j = array1.Length - 1;
            int k = array2.Length - 1;

            while (j >= 0 && k >= 0)
            {
                if (array1[j] == array2[k])
                {
                    rightCommonEnd++;
                }
                j--;
                k--;
            }


            Console.WriteLine(Math.Max(leftCommonEnd, rightCommonEnd));
            
        }
    }
}
