using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halmazok
{
    class Halmazok
    {
        private int[] egyes, kettes;
        private int elemszam1;
        private int elemszam2;
        private char key;
        private Random rdm = new Random();
        public Halmazok(int[] egyes, int[] kettes, int elemszam1, int elemszam2)
        {
            this.egyes = egyes;
            this.kettes = kettes;
            this.elemszam1 = elemszam1;
            this.elemszam2 = elemszam2;
        }
        public Halmazok() { }
        public void feltolt1()
        {
            Console.WriteLine("Az első halmaz elemeinek számna: ");
            //elemszam1 100 és 200 közötti random számokkal való feltöltése
            elemszam1 = int.Parse(Console.ReadLine());
            if (elemszam1 > 200) { elemszam1 = rdm.Next(100, 200); }
            egyes = new int[elemszam1];
            for (int i = 0; i < elemszam1; i++) { egyes[i] = rdm.Next(-100, 100); Console.Write("{0} ", egyes[i]); } 

        }
        public int[] feltolt2_x() { 
            return this.kettes; }
        public int[] feltolt1_x() { 
            return this.egyes; }
        public void feltolt2()
        {
            Console.WriteLine("\nA második halmaz elemeinek száma: ");
            //elemszam2 100 és 200 közötti random számokkal való feltöltése
            elemszam2 = int.Parse(Console.ReadLine());
            if (elemszam2 > 200) { elemszam2 = rdm.Next(100, 200); }
            kettes = new int[elemszam2];
            for (int i = 0; i < elemszam2; i++) { kettes[i] = rdm.Next(-100, 100); Console.WriteLine("{0} ", kettes[i]); } 
        }
        public void valasz()
        {
            //Egyes betűk funkcióinak megadása: 

            Console.WriteLine("\nVálaszd ki a műveletet:\nu = Unió\nm = Metszet\na = A-B\nb = B-A\n");
            key = Console.ReadKey().KeyChar;

            if (key == 'u') // Unió
            {
                IEnumerable<int> unio = feltolt1_x().Union(feltolt2_x());
                Console.WriteLine();
                Console.WriteLine("\nA 2 halmaz uniójába tartozó számok: ");
                foreach (int un in unio) { Console.Write("{0} ", un); }
            }
            else if (key == 'm') // Metszet
            {
                int n = elemszam1; //a tömb mérete
                int m = elemszam2; //b tömb mérete
                int o = n + m;
                int[] metszet = new int[o];
                int j;
                int k = 0;

                for (int i = 0; i < n; i++)
                {
                    j = 0;
                    while (j < m && feltolt2_x()[j] != feltolt1_x()[i]) { j++; }
                    if (j < m)
                    {
                        metszet[k] = feltolt1_x()[i];
                        k++;
                    }
                }

                o = k;
                for (int i = 0; i < o; i++)
                {
                    if (metszet == null)
                    {
                        Console.Write("\nA 2 tömb metszetében nincs szám");
                    }
                    else
                    {
                        Console.Write("\nA 2 tömb metszete: \n{0}", metszet[i]);
                    }
                }

            }
            else if (key == 'a') // A halmazból B halmaz
            {
                IEnumerable<int> ab = feltolt1_x().Except(feltolt2_x());
                Console.WriteLine("\nA 2 halmaz külömbsége (A-B) ");
                foreach (int aa in ab) { Console.Write("{0} ", aa); }
            }
            else if (key == 'b') // B halmazból A halmaz
            {
                IEnumerable<int> bb = feltolt2_x().Except(feltolt1_x());
                Console.WriteLine("\nA 2 halmaz külömbsége (B-A) ");
                foreach (int ba in bb) { Console.Write("{0} ", ba); }
            }
            else
            { Console.WriteLine("\nAdj meg egy karaktert a felsoroltak közül: "); }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Halmazok megoldas = new Halmazok();
            megoldas.feltolt1();
            megoldas.feltolt2();
            megoldas.valasz();
            Console.ReadKey();
        }
    }
}