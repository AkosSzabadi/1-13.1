using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulátor
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam1;
            int szam2;
            char muvjel;
            float ered = 0;
            string uzen = "A művelet eredménye: ";


            szam1 = int.Parse(Console.ReadLine());
            szam2 = int.Parse(Console.ReadLine());
            muvjel = Convert.ToChar(Console.Read());

            switch (muvjel)
            {
                case '+':
                    ered = szam1 + szam2;
                    break;

                case '-':
                    ered = szam1 - szam2;
                    break;

                case '*':
                    ered = szam1 * szam2;
                    break;

                case '/':
                    ered = szam1 / szam2;
                    break;

                default:
                    uzen = "Hiba";
                    break;
            }
            Console.WriteLine(uzen + ered);
            Console.ReadKey();
        }
    }
}
