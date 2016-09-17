using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = 0; j <= n - 1; j++)
                {
                    for (int k = 0; k <= n - 1; k++)
                    {
                        Console.Write((char)('a' + i));
                        Console.Write((char)('a' + j));
                        Console.WriteLine((char)('a' + k));
                    }
                }
            }
        }
    }
}
