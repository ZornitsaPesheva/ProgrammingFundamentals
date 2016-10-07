using System;
using System.Linq;

namespace _03.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().
                Split(' ').Select(int.Parse).ToArray();
            int k = array.Length / 4;
            int[] firstRow = Fold(array, k);
            int[] secondRow = CutMiddle(array, k);
            int[] result = SumArr(firstRow, secondRow);
            Console.WriteLine(string.Join(" ", result));
        }

        private static int[] SumArr(int[] firstRow, int[] secondRow)
        {
            int[] newArray = new int[firstRow.Length];
            for (int i = 0; i < firstRow.Length; i++)
            {
                newArray[i] = firstRow[i] + secondRow[i];
            }
            return newArray;
        }

        private static int[] CutMiddle(int[] array, int k)
        {
            int[] newArray = new int[k * 2];
            for (int i = 0; i < k * 2; i++)
            {
                newArray[i] = array[i + k];
            }
            return newArray;
        }

        // взема първите и последните k в отделен масив
        private static int[] Fold(int[] array, int k)
        {
            int[] newArray = new int[2 * k];
            for (int i = 0; i < k; i++)
            {
                newArray[i] = array[k - i - 1];
            }
            int x = k;
            for (int i = 4 * k - 1; i >= 3 * k; i--)
            {
                newArray[x] = array[i];
                x++;
            }
            return newArray;
        }
    }
}
