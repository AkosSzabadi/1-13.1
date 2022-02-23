using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat_feladat2
{
    class Program
    {
        static void Main(string[] args)
        {
            string cim;
            string oldalak;
            int a;
            int i = 0;

            Console.WriteLine("Add meg a könyv címét: ");
            Console.ReadLine();

            Console.WriteLine("Add meg az oldalainak a számát: ");
            oldalak = Console.ReadLine();
            a = Convert.ToInt32(oldalak);

            if (a > 150)
                Console.WriteLine("A könyv hosszú terjedelmű.");
            else 
                Console.WriteLine("A könyv rövid terjedelmű.");

            Console.ReadKey();    
        }
    }
}
