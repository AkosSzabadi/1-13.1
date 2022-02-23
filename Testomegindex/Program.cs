using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testomegindex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem, adja meg a testsúlyát kg-ban: ");
            double testSuly = double.Parse(Console.ReadLine());
            Console.Write("Kérem, adja meg a magasságát méterben: ");
            double testMagassag = double.Parse(Console.ReadLine());
            double ttIndex = (testSuly / (testMagassag * testMagassag));
            Console.WriteLine("Az Ön testtömeg-indexe: " + ttIndex);

            double v = ttIndex;

            if (v >= 20.5 && v <= 26.5)
            {
                Console.WriteLine("Gratulálunk! A testtömeg-indexe normál!");
            }
            else if (v >= 26.6 && v <= 31.9)
            {
                Console.WriteLine("Ön túlsúlyos!");
            }
            else if (v >= 32.0 && v <= 36.9)
            {
                Console.WriteLine("I. fokú elhízás!");
            }
            else if (v >= 37.0 && v <= 41.9)
            {
                Console.WriteLine("II. fokú elhízás!");
            }
            else
            {
                Console.WriteLine("III. fokú elhízás!");
            }
            Console.ReadKey();
        }
    }
}
