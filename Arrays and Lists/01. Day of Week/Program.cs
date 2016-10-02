using System;

namespace _01.Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int day = int.Parse(Console.ReadLine());
            if (day > 0 && day < 8)
            {
                Console.WriteLine(arr[day - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
