using System;

namespace _09.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            char[] array = new char[26];

            char currentChar = 'a';
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = currentChar;
                currentChar++;
            }

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (word[i] == array[j])
                    {
                        Console.WriteLine($"{word[i]} -> {j}");
                    }
                }
            }
        }
    }
}
