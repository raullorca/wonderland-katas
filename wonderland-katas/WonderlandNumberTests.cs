using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace wonderland_katas
{
    [TestClass]
    public class WonderlandNumberTests
    {
        [TestMethod]
        public void IsMagicNumber()
        {
            var magicNumbers = new List<int>();
            for (int number = 100000; number <= 999999; number++)
            {
                if (Wonderland.IsMagicNumber(number))
                    magicNumbers.Add(number);
            }

            Assert.IsTrue(magicNumbers.Any());
            Assert.AreEqual(1, magicNumbers.Count);
            Assert.AreEqual(142857, magicNumbers[0]);
        }



        [TestMethod]
        public void IsMagicNumber_ByNumber()
        {
            var items = new int[,]
            {
                { 2, 125874 },
                { 3, 100035 },
                { 4, 102564 },
                { 5, 142857 },
                { 6, 106848 }
            };

            for (int i = 0; i <= items.GetLength(0) - 1; i++)
            {
                var result = Wonderland.IsMagicNumber(items[i, 1], items[i, 0]);
                Assert.IsTrue(result);
            }

        }

        [TestMethod]
        public void CompararNumeros()
        {
            var origen = new int[] { 1, 2, 3, 4, 5, 6 };
            var destino = new int[] { 6, 5, 4, 3, 2, 1 };
            var resultado = Wonderland.CompararNumeros(origen, destino);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void GenerateArray()
        {
            var origen = 123456;
            var esperado = new int[] { 1, 2, 3, 4, 5, 6 };
            var resultado = Wonderland.GenerateArray(origen);
            Assert.AreEqual(resultado[0], esperado[0]);
            Assert.AreEqual(resultado[1], esperado[1]);
            Assert.AreEqual(resultado[2], esperado[2]);
            Assert.AreEqual(resultado[3], esperado[3]);
            Assert.AreEqual(resultado[4], esperado[4]);
            Assert.AreEqual(resultado[5], esperado[5]);
        }
    }
}
