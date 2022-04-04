using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Menu
    {
        private string 
        menu1 = "Első Menu",
        menu2 = "Második Menu",
        menu3 = "Harmadik Menu",
        menu4 = "Negyedik Menu";
        public Menu() { }
        public void Osszes()
        {
            Console.WriteLine("1 {0}\n2 {1}\n3 {2}\n4 {3}\n5 Kilépés", menu1, menu2, menu3, menu4);
            int szam = int.Parse(Console.ReadLine());


            if (szam == 1)
            {
                Console.WriteLine("Ezt a menüt választotta:\n{0}", menu1);
                Console.WriteLine("---Feladat vége---");
            }
            else if (szam == 2)
            {
                Console.WriteLine("Ezt a menüt választotta:\n{0}", menu2);
                Console.WriteLine("---Feladat vége---");
            }
            else if (szam == 3)
            {
                Console.WriteLine("Ezt a menüt választotta:\n{0}", menu3);
                Console.WriteLine("---Feladat vége---");
            }
            else if (szam == 4)
            {
                Console.WriteLine("Ezt a menüt választotta:\n{0}", menu4);
                Console.WriteLine("---Feladat vége---");
            }
            else if (szam == 5)
            {
                Console.WriteLine("A feladat befejezéséhez nyomjon entert!");
                Console.WriteLine("---Feladat vége---");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Menu eredmeny = new Menu();
            eredmeny.Osszes();
            Console.ReadKey();

        }
    }
}
