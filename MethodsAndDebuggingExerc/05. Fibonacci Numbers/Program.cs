using System;

namespace _05.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long fibN = Fib(n);
            Console.WriteLine(fibN);
        }

        private static long Fib(int n)
        {
            long prepre = 0;
            long pre = 1;
            for (int i = 1; i <= n; i++)
            {
                long fib = prepre + pre;
                prepre = pre;
                pre = fib;
            }
            return pre;
        }
    }
}
