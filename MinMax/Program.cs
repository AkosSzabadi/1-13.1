using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    public class Unit
    {
        private int min = 0;
        private int max = 0;
        private int[] tomb;
        private int[] tomb2;
        private int hossz;
        public Unit(int hossz, int[] tomb)
        {
            this.tomb = tomb;
            this.hossz = hossz;
        }
        public void tombok()
        {
            tomb2 = new int[this.hossz];
            for (int i = 0; i < tomb2.Length; i++)
            {
                tomb2[i] = this.tomb[i];
            }
        }
        public int mina()
        {
            min = this.tomb2.Min();
            Console.WriteLine("Legkisebb szám {0} " , min);
            return min;
        }
        public int maxa()
        {
            max = this.tomb2.Max();
            Console.WriteLine("Legnagyobb szám {0} ", max);
            return max;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[]{1,2,3,4,5}; 
            Unit megoldas = new Unit(5,tomb);
            megoldas.tombok();
            megoldas.mina();
            megoldas.maxa();
            Console.ReadKey();
        }
    }
}
