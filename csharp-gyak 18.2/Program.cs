using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaratLapoz
{
    class Lapoz
    {
        private string nev;
        private DateTime szuletes;
        private char nem;
        private int buli, tovabb = 0;
        private string sor;
        private string[] mezo;



        public Lapoz() { }

        public Lapoz(string nev, DateTime szuletes, char nem, int buli)
        {
            this.nev = nev;
            this.szuletes = szuletes;
            this.nem = nem;
            this.buli = buli;
        }

        public void printBarat()
        {
            Console.WriteLine("{0,-20} {1,-10} {2,1} {3}", this.nev, this.szuletes.ToShortDateString(), this.nem, this.buli);
        }
        private List<Lapoz> baratLista = new List<Lapoz>();
        public void bekeres()
        {
            using (StreamReader sr = new StreamReader("baratlapoz.txt", Encoding.Default))
                while (sr.EndOfStream == false)
                {
                    sor = sr.ReadLine();
                    if (sor.Trim().Length == 0) continue;

                    mezo = sor.Split('|');

                    baratLista.Add(new Lapoz(
                        mezo[0],
                        DateTime.Parse(mezo[1]),
                        char.Parse(mezo[2]),
                        int.Parse(mezo[3])));
                }
        }
        public void Kiir()
        {
            var elso = baratLista.GetRange(0, 20);
            var masodik = baratLista.GetRange(20, 20);
            var harmadik = baratLista.GetRange(40, 20);
            var negyedik = baratLista.GetRange(60, 20);
            var otodik = baratLista.GetRange(80, 20);
            do
            {
                if (tovabb == 0)
                {
                    foreach (Lapoz key in elso)
                    {
                        key.printBarat();
                    }
                }
                else if (tovabb == 1)
                {
                    foreach (Lapoz key in masodik)
                    {
                        key.printBarat();
                    }
                }
                else if (tovabb == 2)
                {
                    foreach (Lapoz key in harmadik)
                    {
                        key.printBarat();
                    }
                }
                else if (tovabb == 3)
                {
                    foreach (Lapoz key in negyedik)
                    {
                        key.printBarat();
                    }
                }
                else if (tovabb == 4)
                {
                    foreach (Lapoz key in otodik)
                    {
                        key.printBarat();
                    }
                }
                var gomb = Console.ReadKey(true);
                if (gomb.Key == ConsoleKey.PageUp)
                {
                    Console.Clear();
                    tovabb = tovabb + 1;
                }
                else if (gomb.Key == ConsoleKey.Home)
                {
                    Console.Clear();
                    tovabb = 0;
                }
                else if (gomb.Key == ConsoleKey.End)
                {
                    Console.Clear();
                    tovabb = 4;
                }
                else if (gomb.Key == ConsoleKey.PageDown)
                {
                    Console.Clear();
                    tovabb = tovabb - 1;
                }
                else { Console.Clear(); continue; 
                }
            } while (tovabb > -1 && tovabb < 5);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Lapoz bl = new Lapoz();
            bl.bekeres();
            bl.Kiir();
        }
    }
}