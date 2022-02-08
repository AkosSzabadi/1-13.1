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
                START:  
                
                    Console.WriteLine("Válassz játékmódot!");
                    Console.WriteLine("1 - Te gondolsz egy számra");
                    Console.WriteLine("2 - A számítógép gondol egy számra");

                    switch (Console.ReadKey(true).KeyChar)
                    {
                        case '1': goto PLAYER;
                        case '2': goto COMPUTER;
                    }
                PLAYER: goto END;

                COMPUTER: goto END;

                END: 
                    Console.WriteLine("\nAkarsz még játszani? i/n");
                    switch (Console.ReadKey(true).KeyChar)
                    {
                        case 'i': goto START;
                        case 'n': break;
                        default: goto END;
                    }
        PLAYER:
            Console.WriteLine("Gondolj egy számra! (1 - 100)");
            Console.ReadLine();

            x = 50;
            int min = 0;
            int max = 100;
            while (i < 5)
            {
                Console.WriteLine("A számítógép szerint a szám {0}", x);
                Console.WriteLine("Szerinted? (k/n/e)");

                switch (Console.ReadKey(true).KeyChar)
                {
                    case 'k':
                        if (i == 3) 
                            x = r.Next(min, x);
                        else
                        {
                            max = x;
                            x -= (max - min) / 2;
                        }
                        break;
                    case 'n':
                        if (i == 3)
                            x = r.Next(x + 1, max);
                        else
                        {
                            min = x;
                            x += (max - min) / 2;
                        }
                        break;
                    case 'e':
                        Console.WriteLine("A számítógép nyert!");
                        goto END; 
                }
                ++i;
            }
        }
    }
}
