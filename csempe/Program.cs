using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csempezes
{
    class Program
    {
        static void Main(string[] args)
        {
            double szelesseg = 0,
                magassag = 0,
                csempeszam = 0,
                terulet = 0,
                darabszam = 0,
                csempemeret = 0;
            Console.WriteLine("Add még a szoba szélességét!");
            szelesseg = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Add még a szoba magasságát!");
            magassag = Convert.ToDouble(Console.ReadLine());
            // 20x20 csempe
            csempemeret = Math.Pow(0.2, 2);
            terulet = szelesseg * magassag;
            darabszam = (terulet / csempemeret) * 1.1;
            Console.WriteLine("Szükséges csempeszám: {0} db", darabszam);
            Console.ReadKey();

        }
    }
}
