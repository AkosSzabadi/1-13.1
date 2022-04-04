using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorozatok
{
    class Sorozat
    {
        private double[] sorozat = new double[4];

        public void bekeres()
        {
            //A 4 szám beolvasása
            Console.WriteLine("Írj be 4db számot");
            sorozat[0] = Convert.ToDouble(Console.ReadLine());
            sorozat[1] = Convert.ToDouble(Console.ReadLine());
            sorozat[2] = Convert.ToDouble(Console.ReadLine());
            sorozat[3] = Convert.ToDouble(Console.ReadLine());
            //A 4 változót feltöltöm a tömbe
            Console.WriteLine("Beírható számok (4 db): ");
            double elso = sorozat[0];
            double masodik = sorozat[1];
            double harmadik = sorozat[2];
            double negyedik = sorozat[3];
            //számtani sorozat
            for (int i = 0; i < sorozat.Length; i++)
            {
                Console.WriteLine(sorozat[i]);
            }
            if (negyedik - harmadik == harmadik - masodik & harmadik - masodik == masodik - elso)
            {
                Console.WriteLine("A megadott számok alapján ez egy számtani sorozat!");
            }
            //mértani sorozat
            else
            {
                if (negyedik / harmadik == harmadik / masodik & harmadik / masodik == masodik / elso)
                {
                    Console.WriteLine("A megadott számok alapján ez egy mértani sorozat!");
                }
                //Egyik feltételnek sem felel meg
                else { Console.WriteLine("A megadott számok alapján ez a sorozat sem mértani, sem pedig számtani."); }
            }
        }
        public Sorozat() { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sorozat Eredmeny = new Sorozat();
            Eredmeny.bekeres();
            Console.ReadKey();
        }
    }
}
