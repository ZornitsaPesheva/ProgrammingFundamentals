using System;

namespace _04.Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            decimal reversed = ReverseN(n);
            Console.WriteLine(reversed);
        }

        private static decimal ReverseN(decimal n)
        {
            string str = n.ToString();
            string rstr = ReverseS(str);
            return decimal.Parse(rstr);

        }

        private static string ReverseS(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
