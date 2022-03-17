using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponthatarok
{
    class Program
    {
        static void Main(string[] args)
        {
            int pont = 0;
            Console.WriteLine("Hogyan sikerült a 100 pontos dolgozatod?\nKiváncsi vagy rá?");
            Console.WriteLine("Add meg hány pontot értél el a dolgozatban!:");
            pont = int.Parse(Console.ReadLine());
            if (pont > 100)
            {
                Console.WriteLine("Kérlek pontos adatot adj meg!");
            }
            else if (pont >= 90)
            {
                Console.WriteLine("Gratulálunk |Jegyes| dolgozatot írtál!\nPontjaid: 100/{0}", pont);
            }
            else if (pont >= 80)
            {
                Console.WriteLine("Ügyes vagy |Jó| dolgozatot írtál\nPontjaid: 100/{0}", pont);
            }
            else if (pont >= 65)
            {
                Console.WriteLine("Szép volt |Közepes| dolgozatot írtál\nPontjaid: 100/{0}", pont);
            }
            else if (pont >= 50)
            {
                Console.WriteLine("Tanulj keményebben.. |Elégséges| dolgozatot írtál\nPontjaid: 100/{0}", pont);
            }
            else if (pont < 50)
            {
                Console.WriteLine("Kérlek legközelebb jobban figyelj oda! |Elégtelen| dolgozatot írtál\nPontjaid: 100/{0}", pont);
            }
            else if (pont < 0)
            {
                Console.WriteLine("Kérlek pontos adatot adj meg!");
            }

            Console.ReadKey();
        }
    }
}
