using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlaghomerseklet
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = -11;
            int min = 31;
            int atlaghomerseklet = 0;
            int napi = 0; // Ebbe gyűjtük a napi hőmérsékleteket
            int atlagmin = 31; // Havi legkisebb átlaghőmérséklet
            int atlagmax = -11; // Havi legnagyobb átlaghőmérskélet
            int haviatlag = 0;
            int minuszho = 0;
            int minusznap = 0;


            int[,] tomb = new int[30, 12];
            int[] atlagok = new int[12];
            int napok = 0;
            int honapok = 0;
            Random r = new Random();
            // Tömb feltöltése
            for (napok = 0; napok < 30; napok++)
            {
                for (honapok = 0; honapok < 12; honapok++)
                {
                    tomb[napok, honapok] = r.Next(-10, 30);
                }

            }
            // Legmelegebb és leghidegebb napok 
            for (napok = 0; napok < 30; napok++)
            {
                for (honapok = 0; honapok < 12; honapok++)
                {
                    //Leghidegebb elem kiválasztása
                    if (tomb[napok, honapok] < min)
                    {
                        min = tomb[napok, honapok];

                    }
                    //Legmelegebb elem kiválasztása
                    if (tomb[napok, honapok] > max)
                    {
                        max = tomb[napok, honapok];
                    }
                }
            }
            Console.WriteLine("Legmelegebb nap: ",min);
            Console.WriteLine("Leghidegebb nap: ", max);
            // Átlaghőmérséklet 
            for (honapok = 0; honapok < 30; honapok++)
            {
                napi = 0;
                for (napok = 0; napok < 12; napok++)
                {
                    napi = tomb[napok, honapok];
                }
                haviatlag = napi / 30;
                if (haviatlag < atlagmin)
                {
                    atlagmin = honapok;
                }
                if (haviatlag > atlagmax)
                {
                    atlagmax = honapok;
                }
            }
            Console.WriteLine("Átlaghőmérséklet: ",atlagmin);
            // 5 mínusz hőmérsékleti nap
            for (honapok = 0; honapok < 30; honapok++)
            {
                for (napok = 0; napok < 12; napok++)
                {
                    if (tomb[napok, honapok] < 0 && tomb[napok + 1, honapok] < 0 && tomb[napok + 2, honapok] < 0 && tomb[napok + 3, honapok] < 0 && tomb[napok + 4, honapok] < 0)
                    {
                        minuszho = honapok;
                        minusznap = napok;
                        break;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
