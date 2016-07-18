using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace wonderland_katas
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void TestMethod1()
        //{
        //    List<int> lista = new List<int>();
        //    var listaDivisores = new List<int> { /*2, 3 , 4, 5,*/ 6 };
        //    for (int i = 100000; i <= 999999; i++)
        //    {
        //        foreach (var divisor in listaDivisores)
        //        {
        //            if (Wonderland.IsMagicNumber(i, divisor))
        //                lista.Add(i);
        //        }
        //    }

        //    foreach (var item in lista)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        //[TestMethod]
        //public void IsMagicNumber_with_2()
        //{
        //    var number = 125874;
        //    var divisor = 2;
        //    var result = Wonderland.IsMagicNumber(number, divisor);

        //    Assert.IsTrue(result);
        //}

        [TestMethod]
        public void IsMagicNumber_istrue()
        {
            var items = new int[,]
            {
                { 2, 125874 },
                {3, 100035 },
                {4, 102564 },
                {5, 142857 },
                {6, 106848 },
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

    public class Wonderland
    {

        internal static bool IsMagicNumber(int number, int divisor)
        {
            var arrayOrigen = GenerateArray(number);
            var resultado = number * divisor;
            var arrayDestino = GenerateArray(resultado);
            return CompararNumeros(arrayOrigen, arrayDestino);
        }

        public static int[] GenerateArray(int number)
        {
            var texto = number.ToString().ToCharArray();
            var array = texto.Select(x => Convert.ToInt32(x.ToString())).ToArray();
            return array;
        }

        public static bool CompararNumeros(int[] arrayOrigen, int[] arrayDestino)
        {
            var origenOrdenado = arrayOrigen.OrderBy(x => x).ToArray();
            var destinoOrdenado = arrayDestino.OrderBy(x => x).ToArray();


            for (int i = 0; i < origenOrdenado.Count(); i++)
            {
                if (origenOrdenado[i] != destinoOrdenado[i])
                    return false;
            }
            return true;
        }
    }
}
