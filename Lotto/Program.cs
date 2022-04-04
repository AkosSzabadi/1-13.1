using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Lotto
    {
        public Lotto() { }
        private Random rdm = new Random();
        public void lottozas()
        {
            Console.WriteLine("Írd be, hogy 5/6/7-es lottót szeretnél játszani!");
            int bekeres = int.Parse(Console.ReadLine());
            Console.WriteLine("A következő lottó játékot választottad: {0}-s Lottó", bekeres);
            int[] szamok = new int[bekeres];
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rdm.Next(1, 91);
                Console.WriteLine(szamok[i]);
                for (int k = 0; k < i; k++)
                {
                    if (szamok[i] == szamok[k]) { --i; break; }
                }
            }
        }
    }
 /*   class Program
    {
        static void Main(string[] args)
        {
            Lotto szerencse = new Lotto();
            bool folytat = true;
            do
            {
                szerencse.lottozas();
                Console.WriteLine("Szeretnél még egy sorsolást? i/n");
                char valasz = Console.ReadKey().KeyChar;
                Console.WriteLine("");
                if (valasz == 'n')
                { folytat = false; }
            } while (folytat == true);*/
            Console.ReadKey();

        }
    }
}
