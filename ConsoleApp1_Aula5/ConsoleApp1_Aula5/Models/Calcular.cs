using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Aula5.Models
{
    public class Calcular
    {
        //public static bool VerificarIgualdade(int valor1, int valor2)
        //{
        //    return valor1 == valor2;
        //}

        //public static bool VerificarIgualdade(string valor1, string valor2)
        //{
        //    return valor1 == valor2;
        //}

        //public static bool VerificarIgualdade(double valor1, double valor2)
        //{
        //    return valor1 == valor2;
        //}

        public static bool VerificarIgualdade<T>(T valor1, T valor2)
        {
            return valor1.Equals(valor2);
        }
    }
}
