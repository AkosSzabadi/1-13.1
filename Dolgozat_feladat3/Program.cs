using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat_feladat3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            var nevek = new string[]
            {
                "Kiss Pista","Piros Anna","Nagy Lajos"
            };
            var neveredmeny = new string[3];

            var foglalkozas = new string[]
            {
                "kovács","informatikus","sofőr"
            };
            var fogeredmeny = new string[3];




            Console.WriteLine("Add meg a nevet: ");
            Console.ReadLine();

            Console.WriteLine("Add meg a foglalkozását: ");
            Console.ReadLine();

            Console.WriteLine("Add meg a nemét: (f/n) ");
            Console.ReadLine();
        }
    }
}
