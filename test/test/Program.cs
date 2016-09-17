using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int a = int.Parse(Console.ReadLine());
            if ((a != 0) || (a <= 99) || (a >= 201))
                Console.WriteLine("invalid");
            else Console.WriteLine("valid");
        }
    }
}
