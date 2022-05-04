using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teszt
{
    class Oszthato
    {
        private int beker;
        private int ertek;

        public Oszthato(int beker)
        {
            this.ertek = beker;
        }
        public void setSzam()
        {
            try
            {
                this.ertek = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        public void getSzam()
        {
            if(this.ertek % 3 == 0)
            {
                Console.WriteLine("Három");
            }
            else
            {
                if(this.ertek % 5 == 0)
                {
                    Console.WriteLine("Öt");
                }
            }
            else
            {

            }
            Console.ReadKey();
        }
    }
}
