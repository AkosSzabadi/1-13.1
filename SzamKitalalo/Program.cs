using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzamKitalalo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Változók
            int alsohatar = 1, //Véletlen szám alsó határa
                felsohatar = 100, //Véletlen szám felső határa
                tippalsohatar,
                tippfelsohatar,
                gondoltszam,
                tipp,
                probal = 5; //Próbálkozások maximális száma;
            /* k = Kisebbre gondoltam
               n = nagyobbra gondoltam
               t = eltalálta */

            char valaszom; // A gép tippjére adott válaszom

            bool eltalalta = false; // a gép eltalálta-e a tippet

            Random rnd = new Random();

            //Játék ismétlése
            do
            {
                //Megkérdezem, hogy ki lesz a kitaláló
                Console.WriteLine("Leszel az, aki gondol egy számra? (i/n)");
                eltalalta = false; b
                if (Console.ReadKey().KeyChar == 'n')
                {
                    //Ha a játékos a kitaláló akkor a Gep generalja a szamot
                    gondoltszam = rnd.Next(alsohatar, felsohatar);
                    //A gép gondol egy számot és a játékosnak kell kitalálni, max 5 próbálkozás.
                    for (int i = 0; i <= probal; i++)
                    {
                        //tipp beolvasas
                        Console.WriteLine("\nTippeljen!");
                        tipp = int.Parse(Console.ReadLine());
                        //Kiértékelem a tippet
                        //ha nagyobb a tipp
                        if (gondoltszam < tipp)
                        {
                            Console.WriteLine("Kisebb számra gondoltam");
                        }
                        //Ha kisebb a tipp.
                        else if (gondoltszam > tipp)
                        {
                            Console.WriteLine("Nagyobb számra gondoltam");
                        }
                        //ha pontos a tipp.
                        else
                        {
                            eltalalta = true;
                            Console.WriteLine("Gratulálok, eltaláltad");
                            break;
                        }
                    }
                    if (!eltalalta)
                    {
                        Console.WriteLine("Nem nyertél");
                    }
                }
                //Ha a gép a kitaláló         
                else
                {
                    //megadom a kezdeti értéket
                    eltalalta = false;
                    //tipp határainak meghatározása
                    tippalsohatar = alsohatar;
                    tippfelsohatar = felsohatar;
                    //a gép tippel
                    Console.WriteLine("\nGondolj egy számra!");
                    for (int i = 0; i <= probal; i++)
                    {
                        //a gép tippjének meghatározása
                        tipp = tippalsohatar + (tippfelsohatar - tippalsohatar) / 2;
                        Console.WriteLine("\nPC: A tippem: {0}", tipp);
                        Console.WriteLine("\nEltaláltam a számot? \nk = Kisebb a szám | n = nagyobb a szám | t = ez az a szám");
                        //Kiértékelem a tippet megadom a választ
                        valaszom = Console.ReadKey().KeyChar;
                        if (valaszom == 'n')
                        {
                            Console.WriteLine("\nNagyobbra gondoltam!");
                            tippalsohatar = tipp;
                        }
                        else if (valaszom == 'k')
                        {
                            Console.WriteLine("\nKisebbre gondoltam!");
                            tippfelsohatar = tipp;
                        }
                        else
                        {
                            eltalalta = true;
                            Console.WriteLine("\nGratulálok eltalálta");
                            break;
                        }
                    }
                    // kiirom nem találta el, ha nem találta el 5.re
                    if (!eltalalta)
                    {
                        Console.WriteLine("Sajnos nem találta el!");
                    }

                }
                //kérdés h akarsz-e újra játszani
                Console.WriteLine("\nFolytatjuk a játékot? (i/n)");
            } while (Console.ReadKey(true).KeyChar == 'i');
            // sor kiirtekeles
        }
    }
}
