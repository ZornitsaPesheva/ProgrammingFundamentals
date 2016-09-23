using System;

namespace _18.Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
         
            try
            {
                long n = long.Parse(num);
                Console.WriteLine($"{num} can fit in:");
                if (n >= -128 && n <= 127)
                {
                    Console.WriteLine("* sbyte");
                }
                if (n >= 0 && n <= 255)
                {
                    Console.WriteLine("* byte");
                }
                if (n >= -32768 && n <= 32767)
                {
                    Console.WriteLine("* short");
                }
                if (n >= 0 && n <= 65535)
                {
                    Console.WriteLine("* ushort");
                }
                if (n >= -2147483648 && n <= 2147483647)
                {
                    Console.WriteLine("* int");
                }
                if (n >= 0 && n <= 4294967295)
                {
                    Console.WriteLine("* uint");
                }
                if (n >= Int64.MinValue && n <= Int64.MaxValue)
                {
                    Console.WriteLine("* long");
                }
            }
           
            catch
            {
                Console.WriteLine($"{num} can't fit in any type");
            }
        }
    }
}
