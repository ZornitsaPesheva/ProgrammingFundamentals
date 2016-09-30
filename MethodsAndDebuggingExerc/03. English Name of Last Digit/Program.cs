using System;

namespace _03.English_Name_of_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            string lastDig = LastDigit(n);
            Console.WriteLine(lastDig);
        }

        private static string LastDigit(long n)
        {
            long last = Math.Abs(n % 10);
            string digName = "";
            switch (last)
            {
                case 1:
                    digName = "one";
                    break;
                case 2:
                    digName = "two";
                    break;
                case 3:
                    digName = "three";
                    break;
                case 4:
                    digName = "four";
                    break;
                case 5:
                    digName = "five";
                    break;
                case 6:
                    digName = "six";
                    break;
                case 7:
                    digName = "seven";
                    break;
                case 8:
                    digName = "eight";
                    break;
                case 9:
                    digName = "nine";
                    break;
                case 0:
                    digName = "zero";
                    break;
            }
            return digName;
        }
    }
}
