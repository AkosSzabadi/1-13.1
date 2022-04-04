using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binaris
{
    class Binaris
    {
        private string beolvas = "";
        private int darab = 0;
        public Binaris() { }
        public void megoldas()
        {
            Console.WriteLine("Írjon be bináris számokat! ");
            beolvas = Console.ReadLine();
            for (int i = 0; i < beolvas.Length; i++)
            { if (beolvas[i] == '1') { darab += 1; }}
            Console.WriteLine("{0} darab 1-es van a beírt bináris számban! ", darab);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Binaris eredmeny = new Binaris();
            eredmeny.megoldas();
            Console.ReadKey();
        }
    }
}
