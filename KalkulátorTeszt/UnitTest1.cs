using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Kalkulátor;

namespace KalkulátorTeszt
{
    [TestClass]
    public class UnitTest1
    {
        static int tszam1 = 100;
        static int tszam2 = 50;
        static char a = '+', b = '-', c = '*', d = '/';

        Unit osszead = new Unit(tszam1, tszam2, a); //Összeadás
        Unit kivon = new Unit(tszam1, tszam2, b); //Kivonás
        Unit oszt = new Unit(tszam1, tszam2, d); //Osztás
        Unit szoroz = new Unit(tszam1, tszam2, c); //Szorzás
        Unit kivonnull = new Unit(tszam1, 0, d); //0-val 

        [TestMethod]
        public void TestOsszead()
        {
            //Arrange
            var vart = tszam1 + tszam2; // 150;

            //Act
            var kapott = osszead.Eredmeny();

            //Assert
            Assert.AreEqual(vart,kapott);
        }
        [TestMethod]
        public void TestKivon()
        {
            //Arrange
            var vart = tszam1 - tszam2; // 50;

            //Act
            var kapott = kivon.Eredmeny();

            //Assert
            Assert.AreEqual(vart, kapott);
        }
        [TestMethod]
        public void TestSzoroz()
        {
            //Arrange
            var vart = tszam1 * tszam2; // 500;

            //Act
            var kapott = szoroz.Eredmeny();

            //Assert
            Assert.AreEqual(vart, kapott);
        }
        [TestMethod]
        public void TestOsztas()
        {
            //Arrange
            var vart = tszam1 / tszam2; // 2;

            //Act
            var kapott = oszt.Eredmeny();

            //Assert
            Assert.AreEqual(vart, kapott);
        }
        [TestMethod]
        public void TestNullaval()
        {
            //Arrange
            var vart = 100; // 0;

            //Act
            var kapott = kivonnull.Eredmeny();

            //Assert
            Assert.AreNotEqual(vart, kapott);
        }

    }
}
