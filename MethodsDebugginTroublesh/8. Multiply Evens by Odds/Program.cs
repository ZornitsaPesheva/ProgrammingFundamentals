using System;

namespace _8.Multiply_Evens_by_Odds
{
    class Program
    {
        static int GetMultipleOfEvensAndOdds(int n)
        {
            int sumEvent = GetSumOfEvenDigids(Math.Abs(n));
            int sumOdd = GetSumOfOdDiggids(Math.Abs(n));
            return sumEvent * sumOdd;
        }

        private static int GetSumOfOdDiggids(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }

        private static int GetSumOfEvenDigids(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = GetMultipleOfEvensAndOdds(n);
            Console.WriteLine(sum);
        }
    }
}
