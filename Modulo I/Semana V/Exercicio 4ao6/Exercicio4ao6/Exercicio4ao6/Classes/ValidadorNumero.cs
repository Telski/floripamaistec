using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04ao06.Classes
{
    //  exercicio 06
    public static class ValidadorDeNumeros
    {
        /// <summary>
        /// Verifica se é primo
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static bool EhNumeroPrimo(int numero)
        {

            int contador = 1;

            for (int n = 1; n < numero; n++)
            {
                if (numero % n == 0)
                {
                    contador = contador + 1;
                }
            }

            if (contador == 2)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// número é par ou ímpar
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static string ParOuImpar(int numero)
        {
            if (numero % 2 == 0)
            {
                return "Par";
            }

            return "Impar";
        }

        /// <summary>
        /// número é divisível por outro
        /// </summary>
        /// <param name="dividendo"></param>
        /// <param name="divisor"></param>
        /// <returns></returns>
        public static bool EhDivisivelPor(int dividendo, int divisor)
        {
            if (dividendo % divisor == 0)
            {
                return true;
            }

            return false;
        }
    }
}