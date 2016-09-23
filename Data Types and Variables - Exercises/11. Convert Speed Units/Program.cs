using System;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            uint distance = uint.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            ushort inSeconds = (ushort)((hours * 60 + minutes) * 60 + seconds);

            float mettersPerSecond = (float)distance / inSeconds;
            Console.WriteLine($"{mettersPerSecond}");

            float kilometers = (float)distance / 1000;
            float inHours = ((float)seconds / 60 + minutes) / 60 + hours;
            float kilometersPerHour = kilometers / inHours;
            Console.WriteLine($"{kilometersPerHour}");

            float inMiles = (float)distance / 1609;
            float milesPerHour = inMiles / inHours;
            Console.WriteLine($"{milesPerHour}");
        }
    }
}
