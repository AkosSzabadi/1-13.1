using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MinMax;

namespace MinMaxUT
{
    [TestClass]
    public class UnitTest1
    {
        static int tombh = 5;
        static int[] tomb = new int[] {1,2,3,4,5};
        Unit Fenetudja = new Unit(tombh, tomb);
        [TestMethod]

        public void MinTeszt()
        {
            Fenetudja.tombok();
            //arrange
            var vart = 1;
            //act
            var kapott = Fenetudja.mina();
            //assert
            Assert.AreEqual(vart,kapott);
        }
        [TestMethod]

        public void MaxTeszt()
        {
            //arrange
            Fenetudja.tombok();
            var vart = 5;
            //act
            var kapott = Fenetudja.maxa();
            //assert
            Assert.AreEqual(vart, kapott);
        }
    }
}
