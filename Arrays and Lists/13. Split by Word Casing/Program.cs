using System;
using System.Collections.Generic;

namespace _13.Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[]
            {
                ',', ';', ':', '.', '!', '(', ')', '"','\'', '\\', '/', '[',
                ']', ' '
            };
            string[] words = Console.ReadLine().Split(separators,
                StringSplitOptions.RemoveEmptyEntries);
            List<string> lowerCaseList = new List<string>();
            List<string> upperCaseList = new List<string>();
            List<string> mixedCaseList = new List<string>();

            foreach (string word in words)
            {
                WordType type = GetWordType(word);
                if (type == WordType.UpperCase)
                {
                    upperCaseList.Add(word);
                }
                else if (type == WordType.lowerCase)
                {
                    lowerCaseList.Add(word);
                }
                else
                {
                    mixedCaseList.Add(word); 
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCaseList)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCaseList)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCaseList)}");
        }

        static WordType GetWordType(string word)
        {
            int lowerLetters = 0;
            int upperLetters = 0;
            foreach (char w in word)
            {
                if (char.IsUpper(w))
                {
                    upperLetters++;
                }
                else if (char.IsLower(w))
                {
                    lowerLetters++;
                }
            }
            if (upperLetters == word.Length)
            {
                return WordType.UpperCase;
            }
            if (lowerLetters == word.Length)
            {
                return WordType.lowerCase;
            }
            return WordType.MixedCase;
        }

        enum WordType { UpperCase, MixedCase, lowerCase };

    }
}
