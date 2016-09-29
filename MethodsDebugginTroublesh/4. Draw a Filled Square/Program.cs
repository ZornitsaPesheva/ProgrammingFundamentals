using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintRowOfDashes(n);
            for (int i = 1; i <= n - 2; i++)
            {
                PrinrMiddleRow(n);
            }      
            PrintRowOfDashes(n);
        }

        private static void PrinrMiddleRow(int n)
        {
            Console.Write('-');
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }

        private static void PrintRowOfDashes(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
    }
}
