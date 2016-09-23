using System;

namespace _15.decimalToHex
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int nb = n;
            int r = 0;
            char rs = 'a';
            string hex = "";
            do
            {
                r = n % 16;
                n /= 16;
                if (r >= 10)
                {
                    switch (r)
                    {
                        case 10: rs = 'A'; break;
                        case 11: rs = 'B'; break;
                        case 12: rs = 'C'; break;
                        case 13: rs = 'D'; break;
                        case 14: rs = 'E'; break;
                        case 15: rs = 'F'; break;
                    }
                    hex = rs.ToString() + hex;
                }
                else
                {
                    hex = r.ToString() + hex;
                }
            } while (n / 16 > 0);
            if (n != 0)
            {
                hex = n.ToString() + hex;
            }
            
            Console.WriteLine(hex);

            string str = "";
            while (nb / 2 != 0)
            {
                str = str + (nb % 2);
                nb = nb / 2;
            }
            if (nb % 2 == 1)
            {
                str = str + 1;
            }
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(arr);
        }
    }
}