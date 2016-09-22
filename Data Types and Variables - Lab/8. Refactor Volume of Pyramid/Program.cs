﻿using System;

namespace _8.Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());
            var volume = (length * width * height) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", volume);
        }
    }
}
