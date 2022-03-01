using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objektumorientaltprogramozas
{
    class Allat
    {
        // Osztályváltozók (properties)
        private string nev;
        private string fajta;
        private string szin;
        private int kor;

        public Allat(string nev, string fajta, string szin)
        {
            this.nev = nev;
            this.fajta = fajta;
            this.szin = szin;
        }

        public Allat()
        {
            this.nev = "anonim";
            this.fajta = "ismeretlen";
            this.szin = "fekete";
            this.kor = 0;
        }

        public string getnev()
        {
            return this.nev;
        }
        public string getfajta()
        {
            return this.fajta;
        }
        public string getszin()
        {
            return this.szin;
        }
        public int getkor()
        {
            return this.kor;
        }

        public void setKor(int p)
        {
            if (p > 0 && p < 50)
            {
                this.kor = p;
            }

        }
        public void setNev(string n)
        {
            if (n != "")
            {
                this.nev = n;
            }
        }
        public void setFajta(string f)
        {
            if (f != "")
            {
                this.fajta = f;
            }
        }
        public void setSzin(string s)
        {
            if (s != "")
            {
                this.szin = s;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // példányosítunk objektumokat
            Allat allat1 = new Allat("Bodri", "Puli", "Fekete");
            allat1.setKor(2);
            Console.WriteLine("Az állat neve: {0}\nAz állat fajtája: {1}\nAz állat színe: {2}\nAz állat kora: {3} éves\n", allat1.getnev(), allat1.getfajta(), allat1.getszin(), allat1.getkor());
            Allat allat2 = new Allat("Bolhás", "Komondor", "Fehér");
            allat2.setKor(10);
            Console.WriteLine("Az állat neve: {0}\nAz állat fajtája: {1}\nAz állat színe: {2}\nAz állat kora: {3} éves\n", allat2.getnev(), allat2.getfajta(), allat2.getszin(), allat2.getkor());
            Allat allat3 = new Allat();
            allat3.setKor(23);
            allat3.setNev("CsicskaLángos");
            allat3.setFajta("Kuvasz");
            allat3.setSzin("Barna");
            Console.WriteLine("Az állat neve: {0}\nAz állat fajtája: {1}\nAz állat színe: {2}\nAz állat kora: {3} éves\n", allat3.getnev(), allat3.getfajta(), allat3.getszin(), allat3.getkor());
            Console.ReadKey();
        }
    }
}

