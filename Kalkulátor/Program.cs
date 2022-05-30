using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulátor
{
    public class Unit
    {
        private int szam1;
        private int szam2;
        private char muvjel;
        private float ered = 0;
        private string uzen = "A művelet eredménye: ";

        public Unit(int szam1, int szam2, char muvjel)
        {
            this.szam1 = szam1;
            this.szam2 = szam2;
            this.muvjel = muvjel;

        }

        public float Eredmeny()
        {
            switch (this.muvjel)
            {
                case '+':
                    this.ered = this.szam1 + this.szam2;
                    break;

                case '-':
                    this.ered = this.szam1 - this.szam2;
                    break;

                case '*':
                    this.ered = this.szam1 * this.szam2;
                    break;
                case '/':
                    try
                    {
                        this.ered = this.szam1 / this.szam2;
                    }
                    catch (DivideByZeroException e)
                    {
                        Console.WriteLine(e.Message);
                        return this.ered = 0;
                    }
                    break;
                default:
                    this.uzen = "Hiba";
                    break;
            }
            Console.WriteLine(this.uzen + this.ered);
            return this.ered;
        }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Adjon meg 2 számnot és egy műveleti jelet: ");
                Unit megoldas = new Unit(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), Convert.ToChar(Console.ReadLine()));
                megoldas.Eredmeny();
                Console.ReadKey();
            }
        }
    }
