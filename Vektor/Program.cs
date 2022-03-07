﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektor
{
    class Vektor
    {
        private double hossz, osszeg;
        private int elemszam;
        private int[] tomb = new int[]{ };


        public Vektor(double hossz, int elemszam) 
        {
            this.hossz = hossz;
            this.elemszam = elemszam;
        }

        Random fel = new Random();
        public Vektor() {}

        public void feltoltes(int elemszam, int[]tomb)
        {
            Console.WriteLine("Vektor hossza: ");
            elemszam = int.Parse(Console.ReadLine());
            for (int i = 0; i<=elemszam; i++)
            {
                tomb[i] = fel.Next();
            }
        }
        public void setÖsszeg()
        {
            for(int i=0;i<tomb.Length;i++)
            {
                osszeg = osszeg + tomb[i];
            }

        }
        public double getTomb()
        {
            return this.elemszam;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vektor R = new Vektor();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
