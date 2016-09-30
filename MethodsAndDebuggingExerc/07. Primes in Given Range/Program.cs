using System;
using System.Collections.Generic;

namespace _07.Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            List<int> primeList = FindPrimesInRange(start, end);
            string numbers = String.Join(", ", primeList.ToArray());
            Console.WriteLine(numbers);
        }

        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> list = new List<int>();
            for (int i = startNum; i <= endNum; i++)
            {
                if (IsPrime(i))
                {
                    list.Add(i);
                }
            }
            return list;
        }

        private static bool IsPrime(int n)
        {
            bool prime = true;
            if (n <= 1)
            {
                prime = false;
            }        
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        prime = false;
                        break;
                    }
                }
            }
            return prime;
        }
    }
}
