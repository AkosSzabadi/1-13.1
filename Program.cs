using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuliszervezesB
{
    class Lapoz
    {
        private string nev;
        private DateTime szuletes;
        private char nem;
        private int buli;
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
        private List<Lapoz> Blist20 = new List<Lapoz>(); 
        public void bekeres()
        {
            using (StreamReader sr = new StreamReader("baratlapoz.txt", Encoding.UTF8))
                while (sr.EndOfStream == false)
                {
                    sor = sr.ReadLine();
                    if (sor.Trim().Length == 0) continue; 

                    mezo = sor.Split(';');

                    baratLista.Add(new Lapoz(
                        mezo[0],
                        DateTime.Parse(mezo[1]),
                        char.Parse(mezo[2]),
                        int.Parse(mezo[3])));
                    if (DateTime.Parse(mezo[1]) < DateTime.Parse("2002.11.05") && int.Parse(mezo[3]) >= 5)
                    {
                        Blist20.Add(new Lapoz(
                        mezo[0],
                        DateTime.Parse(mezo[1]),
                        char.Parse(mezo[2]),
                        int.Parse(mezo[3])));
                    }
                }
        }
        public void Kiir()
        {

            Console.WriteLine("Barátok:");

            foreach (Lapoz key in baratLista)
            {
                key.printBarat();
            }
            Console.WriteLine();
            Console.WriteLine("Barátok neve akiket meghívhatunk a buliba:");

            foreach (Lapoz key in Blist20)
            {
                if (Blist20.Count >= 10)
                {
                    if (Blist20.Count > 15)
                    {
                        Blist20.GetRange(0, 15);
                        Console.WriteLine("{0,-20}", key.nev);
                    }
                    else
                    {
                        Console.WriteLine("{0,-20}", key.nev);
                    }
                }
                else { Console.WriteLine("Legalább 10 fő kell a buli megszervezéséhez!"); 
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Lapoz bl = new Lapoz();
            bl.bekeres();
            bl.Kiir();
            Console.ReadKey();
        }
    }
}