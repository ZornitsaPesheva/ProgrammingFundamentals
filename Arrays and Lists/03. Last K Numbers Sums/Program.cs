using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());
            long[] arr = new long[n];
            arr[0] = 1;
            for (int i = 1; i < n; i++)
            {
                long start = Math.Max(0, i - k);
                long end = i - 1;
                long sum = SumArr(arr, start, end);
                arr[i] = sum;
            }
            Console.WriteLine(String.Join(" ", arr));
        }

        private static long SumArr(long[] arr, long start, long end)
        {
            long sum = 0;
            for (long i = start; i <= end; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
    }
}
