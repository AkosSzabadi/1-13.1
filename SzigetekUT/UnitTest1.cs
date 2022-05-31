using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Sziget;

namespace SzigetekUT
{
    [TestClass]
    public class UnitTest1
    {
        static string tartalom = "0101010111110111110110"; //6 sziget,5 hossz
        Unit eredmeny = new Unit(tartalom);
        [TestMethod]
        public void szigethossz()
        {
            //arrange
            var vart = 5;
            //act
            var kapott = eredmeny.szigethossz();
            //assert
            Assert.AreEqual(vart,kapott);
        }
        [TestMethod]
        public void szigetszam()
        {
            //arrange
            var vart = 6;
            //act
            var kapott = eredmeny.szigetszaama();
            //assert
            Assert.AreEqual(vart, kapott);
        }
    }

}
