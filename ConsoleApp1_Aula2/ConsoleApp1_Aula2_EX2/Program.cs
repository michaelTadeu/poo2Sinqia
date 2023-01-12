using ConsoleApp1_Aula2_EX2.Interfaces;
using ConsoleApp1_Aula2_EX2.Models;

namespace ConsoleApp1_Aula2_EX2
{
    class Program
    {
        public static void Main(string[] args)
        {
            FilaDeMercado filaDeMercado = new FilaDeMercado();
            ILista ilista = filaDeMercado;
            ilista.Remover();
            ICaixa icaixa = filaDeMercado;
            icaixa.Somar();
        }
    }
}