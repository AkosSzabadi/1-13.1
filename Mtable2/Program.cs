using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mtable2
{
    class Program
    {
        static void Main(string[] args)
        {
            int param = args.Length;
            int szam1 = 0;
            int szam2 = 0;

            Random rdm = new Random();
            switch (param)
            {
                case 0:
                    szam1 = rdm.Next(100);
                    szam2 = rdm.Next(100);
                    break;

                case 1:
                    szam1 = int.Parse(args[0]);
                    szam2 = rdm.Next(1, 100);
                    break;

                case 2:
                    szam1 = int.Parse(args[0]);
                    szam2 = int.Parse(args[1]);
                    break;
            }
            Console.WriteLine(szam1*szam2);
            Console.ReadKey();
        }
    }
}
