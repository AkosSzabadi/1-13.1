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
        private int[] tomb= new int[] {};
        public Unit(int[] tomb)
        {
            this.tomb = tomb;
        }
        public int Min()
        {
            min = tomb.Min();
            Console.WriteLine("Legkisebb szám [0] " , min);
            return min;
        }
        public int Max()
        {
            max = tomb.Max();
            return max;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
