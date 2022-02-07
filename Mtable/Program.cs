using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mtable
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam = 0;
            if (args.Length > 0)
            {
                szam = int.Parse(args[0]);
            }
            else
            {
                Random rnd = new Random();
                szam = rnd.Next(1, 50);
            }
            Console.WriteLine(szam*2);
            Console.ReadKey();
        }
    }
}
