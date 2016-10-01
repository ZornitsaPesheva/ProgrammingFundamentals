using System;

namespace _12.Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                if (IsPalindrome(i) && SumOfDigitsIs7(i) && ContainEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool IsPalindrome(int i)
        {
            int n = i;
            int rev = 0;
            while (i > 0)
            {
                int dig = i % 10;
                rev = rev * 10 + dig;
                i = i / 10;
            }
            if (n == rev)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool SumOfDigitsIs7(int i)
        {
            int sum = 0;
            while (i > 0)
            {
                sum += i % 10;
                i = i / 10;
            }
            if (sum % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool ContainEvenDigit(int i)
        {
            while (i > 0)
            {
                if (i % 10 % 2 == 0)
                {
                    return true;
                }
                i /= 10;
            }
            return false;
        }
    }
}
