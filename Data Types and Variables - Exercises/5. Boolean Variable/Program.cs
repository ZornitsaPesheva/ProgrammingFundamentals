using System;

namespace _5.Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string boolean = Console.ReadLine();
            if (Convert.ToBoolean(boolean))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
