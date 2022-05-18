using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGyak
{
    internal class Dolgozat
    {

        private class Jegyek
        {
            public string nev;
            public DateTime dolgozat_datuma;
            public char diak_neme;
            public int jegy;

            public Jegyek() { }

            public Jegyek(string nev, DateTime dolgozat_datuma, char diak_neme, int jegy)
            {
                this.nev = nev;
                this.dolgozat_datuma = dolgozat_datuma;
                this.diak_neme = diak_neme;
                this.jegy = jegy;
            }
            public void printJegyek()
            {
                Console.WriteLine("{0,-20} {1,-10} {2,1} {3}", nev, dolgozat_datuma.ToShortDateString(), diak_neme, jegy);
            }
        }
        private List<Jegyek> DolgozatLista;

        private string fajlnev;

        public Dolgozat()
        {
            DolgozatLista = new List<Jegyek>();
        }
        public void beolvas()
        {
            string sor;
            string[] mezok;

            Console.WriteLine("Adja meg a szövegfájl nevét elérési úttal!");
        }
    }
}
