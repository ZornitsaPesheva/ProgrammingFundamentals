using System;

namespace _02.Sign_of_IntegerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }

        static void PrintSign(int n)
        {
            Console.Write("The number ");
            if (n > 0)
            {
                Console.WriteLine($"{n} is positive.");
            }
            else if (n < 0)
            {
                Console.WriteLine($"{n} is negative.");
            }
            else
            {
                Console.WriteLine($"{n} is zero.");
            }
        }
    }
}
