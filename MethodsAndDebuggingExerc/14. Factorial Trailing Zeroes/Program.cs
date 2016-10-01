using System;
using System.Numerics;

namespace _14.Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = FactorialOfN(n);
            BigInteger trailingZeroes = TrsilingZeros(factorial);
            Console.WriteLine(trailingZeroes);
        }

        private static int TrsilingZeros(BigInteger factorial)
        {
            int zeroes = 0;
            while (factorial % 10 == 0)
            {
                zeroes++;
                factorial /= 10;
            }
            return zeroes;
        }

        private static BigInteger FactorialOfN(int n)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
