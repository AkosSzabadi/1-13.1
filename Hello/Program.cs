using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ez egy egysoros comment
            /*
             Ez többsoros
            */
            //Konstansok
            const string FEJLESZTO = "Szabadi Ákos";
            // valtozok
            string uzenet = "Hello world";
            int szam = 10;
            double szam2 = 10.0;
            bool gender = true;
            char karakter = 's';
            string szoveg = "Szöveg";
            // program törzs
            Console.WriteLine(uzenet);
            Console.WriteLine(szam);
            Console.WriteLine(szam2);
            Console.WriteLine(gender);
            Console.WriteLine(karakter);
            Console.WriteLine(szoveg);
            Console.ReadKey();
        }
    }
}
