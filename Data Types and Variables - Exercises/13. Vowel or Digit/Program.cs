using System;

namespace _13.Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());
            if (symbol == 65 || symbol == 69 || symbol == 73 || symbol == 79 || symbol == 85 || symbol == 89 || symbol == 97 || symbol == 101 || symbol == 105 || symbol == 111 || symbol == 117 || symbol == 121)
            {
                Console.WriteLine("vowel");
            }
            else if (symbol >= 48 && symbol <= 57)
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
