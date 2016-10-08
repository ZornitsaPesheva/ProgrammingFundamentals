using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().
                Split(' ').Select(int.Parse).ToArray();
        //    int[] arr = { 3, 14, 5, 12, 15, 7, 8, 9, 11, 10, 1 };

            int[] len = new int[arr.Length];
            int[] prev = new int[arr.Length];
            len[0] = 1;
            prev[0] = -1;

            int maxIndex = 0;
            for (int x = 0; x < arr.Length; x++)
            {
                len[x] = 1;
                for (int i = 0; i <= x; i++)
                {
                    if (arr[x] > arr[i])
                    {
                        if (arr[x] > arr[i])
                        {
                            prev[x] = i;
                        }                 
                        len[x]++;
                     }
                    
                }
                if (prev[x] > 0)
                {
                   len[x] = 1 + len[prev[x]];
                   maxIndex = prev[x] + 1;
                }
            }
            List<int> result = new List<int>();
            //int lenx = len[end];
            int j = maxIndex;
            while (j >= 0)
            {
                result.Add(arr[j]);
                j = prev[j];
            }
            result.Reverse();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
