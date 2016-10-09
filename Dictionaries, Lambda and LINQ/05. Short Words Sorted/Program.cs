using System;
using System.Linq;

namespace _05.Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[]
                {'.', ',', ':', ';', '(', ')', '[', ']', '\\',
                '\"', '\'', '/', '!', '?', ' '};
            string sentence = Console.ReadLine().ToLower();
            string[] words = sentence.Split(separators);
            var result = words
                .Where(w => w != "")
                .Where(w => w.Length < 5)
                .OrderBy(w => w).Distinct();
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
