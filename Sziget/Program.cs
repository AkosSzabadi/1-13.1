using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sziget
{
    public class Unit
    {
       private string data =string.Empty;
       private int islandCount = 0;
       private int maxIslandLength = 0;
       private int i = 0;

        public Unit(string data)
        {
            this.data = data;
        } 
        public void Vizsgalat()
        {
            while (i < this.data.Length)
            {
                if (this.data[i] == '1')
                {
                    ++islandCount;
                    int j = i;
                    int tmp = 0;
                    // A sziget hosszát számolja(Vagyis az 1-eseket)
                    while (j < this.data.Length && this.data[j] == '1')
                    {
                        ++j;
                        ++tmp;
                    }
                    i = j;

                    if (tmp > maxIslandLength) { maxIslandLength = tmp; }
                }
                // False ág, ez esetben tovább megy a string karakterein
                else
                {
                    ++i;
                }
            }
        }
        public int szigetszaama()
        {
            Vizsgalat();
            Console.WriteLine("Szigetek száma: {0} ",islandCount);
            return islandCount;
        }
        public int szigethossz()
        {
            Vizsgalat();
            Console.WriteLine("Szigetek hossza {0} ", maxIslandLength);
            return maxIslandLength;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Írjon be 0-at és 1-eseket: ");
            Unit megoldas = new Unit(Console.ReadLine());
            megoldas.szigethossz();
            megoldas.szigetszaama();
            Console.ReadKey();
        }
    }
}
