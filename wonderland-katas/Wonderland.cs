using System;
using System.Collections.Generic;
using System.Linq;

namespace wonderland_katas
{
    public class Wonderland
    {
        public static bool IsMagicNumber(int number)
        {
            var divisorList = new List<int> { 2, 3, 4, 5, 6 };
            bool isMagic = true;
            foreach (var item in divisorList)
            {
                if (!IsMagicNumber(number, item))
                {
                    isMagic = false;
                    break;
                }
            }
            return isMagic;
        }
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
