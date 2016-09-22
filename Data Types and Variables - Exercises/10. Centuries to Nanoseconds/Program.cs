using System;

namespace _10.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            Console.Write($"{centuries} centuries = ");
            int years = centuries * 100;
            Console.Write($"{years} years = ");
            int days =(int)(years * 365.2422);
            Console.Write($"{days} days = ");
            int hours = days * 24;
            Console.Write($"{hours} hours = ");
            long minutes = hours * 60;
            Console.Write($"{minutes} minutes = ");
            ulong seconds = (ulong)minutes * 60;
            Console.Write($"{seconds} seconds = ");
            ulong milliseconds = seconds * 1000;
            Console.Write($"{milliseconds} milliseconds = ");
            decimal microseconds = milliseconds * 1000;
            Console.Write($"{microseconds} microseconds = ");
            decimal nanoseconds = microseconds * 1000;
            Console.WriteLine($"{nanoseconds} nanoseconds");
        }
    }
}
