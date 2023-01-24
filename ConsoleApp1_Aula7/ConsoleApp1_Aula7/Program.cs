using System.Globalization;
using System;
using System.Reflection;
using System.Collections;
using ConsoleApp1_Aula7.Model;

namespace ConsoleApp1_Aula7
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Implementação antes da Substituição Liskov (Herança)
            //LerParamentros_OLD lerParamtros = new LerParamentros_OLD();
            //Console.WriteLine(lerParamtros.GetBDConexaoString());

            //lerParamtros = new LerParametrosXML();
            //Console.WriteLine(lerParamtros.GetBDConexaoString());

            LerParamentros lerParamtros = new LerParametrosXML();
            Console.WriteLine(lerParamtros.GetBDConexaoString());

            lerParamtros = new LerParametrosJSON();
            Console.WriteLine(lerParamtros.GetBDConexaoString());

            Console.ReadKey();
        }
    }
}