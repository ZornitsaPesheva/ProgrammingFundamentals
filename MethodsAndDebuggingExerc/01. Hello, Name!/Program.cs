using System;

namespace _01.Hello__Name_
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Greating(name);
        }

        private static void Greating(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
