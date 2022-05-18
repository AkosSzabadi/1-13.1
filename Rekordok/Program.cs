using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekordok
{
    internal class BaratLista
    {
        private class Barat
        {
            private string nev;
            private DateTime szuletett;
            private char neme;
            private int bulis;

            public Barat() {}

            public Barat(string nev, DateTime szuleletett, char neme, int bulis)
            {
                this.nev = nev;
                this.szuletett = szuleletett;
                this.neme = neme;
                this.bulis = bulis;
            }

            public void printBarat()
            {
                Console.WriteLine("{0,-20} {1,-10} {2,1} {3}", nev, szuletett.ToShortDateString(), neme, bulis);
            }
        }

        private List<Barat> baratLista; // Ebben tároljuk a barát dokumentumot

        private string fajlNev;

        public BaratLista()
        {
            baratLista = new List<Barat>(); // Létrehoztzuk a listát
        }

        public void Beolvas()
        {
            string sor; // Egy sor beolvasása
            string[] mezok; // Sor szétbontása

            // Féjlnév beolvasása
            Console.WriteLine("Adja meg a szövegfájl nevét elérési úttal!");
            fajlNev = Console.ReadLine();
            // Ha hiányzik a .txt kiterjesztés, kiegészítjük
            if (!fajlNev.EndsWith(".txt")) fajlNev += ".txt";

            // Beolvasás fájlból
            using ( StreamReader sr = new StreamReader(fajlNev, Encoding.Default))
            while (sr.EndOfStream == false)
                {
                    sor = sr.ReadLine();
                    if (sor.Trim().Length == 0) continue; // Ha üres a sor, akkor létetünk

                    mezok = sor.Split(','); // Szétbontás

                    // Hozzáadás a listához
                    baratLista.Add(new Barat(
                        mezok[0],
                        DateTime.Parse(mezok[1]),
                        char.Parse(mezok[2]),
                        int.Parse(mezok[3])));
                }
        }
        public void Kiir()
        {
            foreach (Barat p in baratLista)
            {
                p.printBarat();
            }
            Console.ReadKey();
        }
    }
}
