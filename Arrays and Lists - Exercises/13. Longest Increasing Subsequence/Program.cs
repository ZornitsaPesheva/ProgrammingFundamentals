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
            int[] arr = { 3, 14, 5, 12, 15, 7, 8, 9, 11, 10, 1 };
            int[] len = new int[11];
            int[] prev = new int[11];

            for (int x = 0; x < arr.Length; x++)
            {
                len[0] = 1;
                prev[0] = -1;
                prev[1] = 0;
                for (int i = 0; i <= x; i++)
                {
                    if (arr[x] > arr[i])
                    {
                        prev[x] = i;
                    }
                }
                if (prev[x] > 0)
                {
                    len[x] = 1 + len[prev[x]];
                }
                else
                {
                    len[x] = 1;
                }
            }

            Console.WriteLine(string.Join(" ", arr));
            Console.WriteLine(string.Join(" ", len));
            Console.WriteLine(string.Join(" ", prev));

        }
    }
}
