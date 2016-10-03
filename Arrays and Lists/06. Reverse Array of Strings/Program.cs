using System;
using System.Linq;

namespace _06.Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] items = Console.ReadLine().Split(' ')
                .ToArray();
            string[] reversedItems = items.Reverse().ToArray();
            Console.WriteLine(string.Join(" ", reversedItems));
        }
    }
}
