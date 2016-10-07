using System;

namespace _04.Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] primes = new bool[n+1];
            for (int i = 0; i <= n; i++)
            {
                primes[i] = true;
            }
            primes[0] = false;
            primes[1] = false;
            int count = 0;

            for (int p = 2; p <= n; p++)
            {
                if (IsPrime(p)){
                    count++;
                //    Console.WriteLine(p);
                    for (int i = 2; i <= n; i++)
                    {
                        if (i * p <= n)
                        {
                            primes[i * p] = false;
                        }
                    }
                }
            }
            int[] primesOnly = ReturnPrimes(primes, count);
            Console.WriteLine(string.Join(" ", primesOnly));
        }

        private static int[] ReturnPrimes(bool[] primes, int count)
        {
            int[] newArr = new int[count];
            int x = 0;
            for (int i = 0; i < primes.Length; i++)
            {
                if (primes[i] == true)
                {
                    newArr[x] = i;
                    x++;
                }
            }
            return newArr;
        }

        private static bool IsPrime(int v)
        {
            bool prime = true;
            if (v <= 1)
            {
                prime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(v); i++)
                {
                    if (v % i == 0)
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
