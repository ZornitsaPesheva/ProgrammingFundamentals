using System;

namespace _6.Strings_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello";
            string s2 = "World";
            object s3 = s1 + " " + s2;
            string str = (string)s3;
            Console.WriteLine(str);
        }
    }
}
