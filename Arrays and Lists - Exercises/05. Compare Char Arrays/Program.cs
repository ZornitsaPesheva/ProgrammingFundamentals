using System;
using System.Linq;

namespace _05.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] array1 = Console.ReadLine().Split(' ')
                .Select(char.Parse).ToArray();
            char[] array2 = Console.ReadLine().Split(' ')
                .Select(char.Parse).ToArray();
            //     int shorter = 0;

            int min = Math.Min(array1.Length, array2.Length);   
            for (int i = 0; i < min; i++)
            {
                if (array1[i] < array2[i] && i < min -1)
                {
                    Console.WriteLine(string.Join("", array1));
                    Console.WriteLine(string.Join("", array2));
                    break;
                }
                else if (array1[i] > array2[i] && i < min - 1)
                {
                    Console.WriteLine(string.Join("", array2));
                    Console.WriteLine(string.Join("", array1));
                    break;
                }
                else
                {
                    if (i == min - 1 && array1.Length == min)
                    {
                        Console.WriteLine(string.Join("", array1));
                        Console.WriteLine(string.Join("", array2));
                    }
                    else if (i == min - 1 && array2.Length == min)
                    {
                        Console.WriteLine(string.Join("", array2));
                        Console.WriteLine(string.Join("", array1));
                    }
                }
            }      
        }
    }
}
