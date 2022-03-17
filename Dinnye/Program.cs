using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinnye
{
    class Program
    {
        static void Main(string[] args)
        {
            int dinnyeszam = 0,
                dinnyeatmero = 0;
            double atmero = 0;
            Console.WriteLine("Add meg a dinnye átmérőjét!");
            dinnyeatmero = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a dinnyék számát");
            dinnyeszam = int.Parse(Console.ReadLine());
            atmero = (((((Math.Pow((dinnyeatmero / 2), 2) * Math.PI) * 2) + 60)) / 1000) * dinnyeszam;
            Console.WriteLine("A dinnye átmérője: {0} cm\nA dinnyék száma: {1} db\nA dinnye csomagolásához szükséges szalag: {2} m", dinnyeatmero, dinnyeszam, Math.Round(atmero, 2));
            Console.ReadKey();
        }
    }
}