using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kör
{

    class Kor
    {
        private double terulet, kerulet;
        protected double sugar;
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
        class Henger : Kor
        {
            private int testmagassag;
            private double t, at;
            public Henger() : base()
            {
                this.testmagassag = 0;
                this.t = 0;
                this.at = 0;

            }
            public void bekeres()
            {
                int M = int.Parse(Console.ReadLine());
                if (M != 0) { this.testmagassag = M; }

            }
            public int bekert()
            {
                return this.testmagassag;
            }
            public double terfogat()
            {
                this.t = alapterulet() * bekert();
                return this.t;
            }
            public double alapterulet()
            {
                this.at = Math.PI * (getSugar() * getSugar());
                return this.at;
            }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Adja meg a kör sugarát : ");
            Henger S = new Henger();
            S.setSugar();
            Console.WriteLine("\nA területe: {0}\n A kerülete: {1}", S.teruletszamol(), S.keruletszamol());
            Console.WriteLine("\nAdd meg a henger sugarát: ");
            S.setSugar();
            Console.WriteLine("\nAdd meg a henger testmagasságát: ");
            S.bekeres();
            Console.WriteLine("\nA henger sugara: {0} \nA henger térfogata: {1} \nA henger alapterülete: {2}", S.getSugar(),S.terfogat(),S.alapterulet());

            Console.ReadKey();
        }
    }
}
