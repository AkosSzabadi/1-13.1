using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Órai
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam;
                do
                { 
                Console.WriteLine("Give me a number: ");
                szam = int.Parse(Console.ReadLine());
                try
                {
                    int szam = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("");
                }
            }
        }
    }
}
