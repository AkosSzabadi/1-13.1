using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat_feladat1
{
    class Program
    {
        static void Main(string[] args)
        {
            string elsoszam;
            string masodikszam;
            int a;
            int b;

            Console.WriteLine("Adj meg egy számot! ");
            elsoszam = Console.ReadLine();
            a = Convert.ToInt32(elsoszam);

            Console.WriteLine("Add meg a második számot! ");
            masodikszam = Console.ReadLine();
            b = Convert.ToInt32(masodikszam);

            if (a > 0 && b > 0)
                Console.WriteLine("Mind a két szám pozitív");
            if (a > 0 && b < 0)
                Console.WriteLine("Az első szám pozitív");
            if (a < 0 && b > 0)
                Console.WriteLine("A második szám pozitív");
            if (a < 0 && b < 0)
                Console.WriteLine("Mind a két szám negatív");

            Console.ReadKey();
        }
    }
}
