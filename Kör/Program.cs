using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kör
{

    class Kor
    {
        private double sugar, terulet, kerulet;
        public Kor(double sugar, double terulet, double kerulet)
        {
            this.sugar = sugar;
            this.terulet = terulet;
            this.kerulet = kerulet;
        }
        public Kor() { }
        public double getSugar()
        {
            return this.sugar;
        }
        public void setSugar()
        {
            double R = int.Parse(Console.ReadLine());
            if (R != 0) { this.sugar = R; }
        }
        public double teruletszamol()
        {
            this.terulet = getSugar() * getSugar() * Math.PI;
            return this.terulet;
        }
        public double keruletszamol()
        {
            this.kerulet = 2 * Math.PI * getSugar();
            return this.kerulet;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Adja meg a sugarat: ");
            Kor S = new Kor();
            S.setSugar();
            Console.WriteLine("\n A területe: {0} \n A kerülete: {1}", S.teruletszamol(), S.keruletszamol());
            Console.ReadKey();
        }
    }
}
