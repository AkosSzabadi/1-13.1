using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoList
{
    internal class AutoList
    {
        private class Auto
        {
            private int rendszam;
            private string gyartmany;
            private string tipus;
            private string tulaj;
            private DateTime gyartasev;
            private DateTime vizsga;

            public Auto() { }

            public Auto(int rendszam, DateTime gyartasev, DateTime vizsga, string gyartmany, string tipus, string tulaj)
            {
                this.rendszam = rendszam;
                this.gyartmany = gyartmany;
                this.gyartasev = gyartasev;
                this.vizsga = vizsga;
                this.tipus = tipus;
                this.tulaj = tulaj;
            }

            public void printAuto()
            {
                Console.WriteLine("{0,-40} {1,-30} {2,-20} {3,-10} {4,1} {5}", rendszam, gyartmany, tipus, gyartasev.ToShortDateString(), vizsga.ToShortDateString(), tulaj);
            }
        }
        private List<Auto> AutoLista;

        private string fajlNev;

        public AutoList()
        {
            AutoLista = new List<Auto>();
        }

        public void Beolvas()
        {
            string sor;
            string[] mezok;

            Console.WriteLine("Adja meg a szövegfájl nevét elérési úttal!");
            fajlNev = Console.ReadLine();
            if (!fajlNev.EndsWith(".txt")) fajlNev += ".txt";

            using (StreamReader sr = new StreamReader(fajlNev, Encoding.Default))
                while (sr.EndOfStream == false)
                {
                    sor = sr.ReadLine();
                    if (sor.Trim().Length == 0) continue;

                    mezok = sor.Split(';');

                    AutoLista.Add(new Auto(
                        int.Parse(mezok[0]),
                        DateTime.Parse(mezok[1]),
                        DateTime.Parse(mezok[2]),
                        mezok[3],
                        mezok[4],
                        mezok[5]));


                }
        }
        public void Kiir()
        {
            foreach (Auto p in AutoLista)
            {
                p.printAuto();
            }
            Console.WriteLine();
        }
    }
}
