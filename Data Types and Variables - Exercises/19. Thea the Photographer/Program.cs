using System;

namespace _19.Thea_the_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int ft = int.Parse(Console.ReadLine());
            int ff = int.Parse(Console.ReadLine());
            int ut = int.Parse(Console.ReadLine());
            long allft = n * (long)ft;
            double percentige = ff / 100.0;
            int goodForUpload = (int)Math.Ceiling(n * percentige);
            long seconds = goodForUpload * (long)ut + allft;
            Console.WriteLine(TimeSpan.FromSeconds(seconds).ToString(new string('d', 1) + @"\:hh\:mm\:ss"));
        }
    }
}
