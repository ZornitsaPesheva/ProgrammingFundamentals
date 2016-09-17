using System;

namespace _5.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0} -> {1}", i, special(i));           
            }
        }

        private static object special(int i)
        {
            int sum = 0;
            do
            {
                sum += i % 10;
                i = i / 10;
            } while (i > 0);
            return ((sum == 5) || (sum == 7) || (sum == 11));
        }
    }
}
