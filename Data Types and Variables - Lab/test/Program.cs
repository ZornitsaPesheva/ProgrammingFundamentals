using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSol___Travel_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            var km = double.Parse(Console.ReadLine());
            var time = Console.ReadLine();

            var taxiDay = 0.79 * km;
            var taxiNight = 0.90 * km;

            if (km < 20)
            {
                var priceTaxi = 0.70;
                if (time == "day")

                { Console.WriteLine(priceTaxi + taxiDay); }
                else if (time == "night")
                {
                    Console.WriteLine(priceTaxi + taxiNight);
                }

                else if (km < 100 && km >= 20)
                    if (time == "day")
                    {
                        Console.WriteLine(km * 0.09);
                    }
                    else if (time == "night")
                    { Console.WriteLine(km * 0.09); }
            }


            else if (km >= 100)
                if (time == "day")
                { Console.WriteLine(km * 0.06); }
                else if (time == "night")
                { Console.WriteLine(km * 0.06); }


        }
    }
}