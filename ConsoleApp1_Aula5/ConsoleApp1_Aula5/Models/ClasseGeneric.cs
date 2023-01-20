using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Aula5.Models
{
    public class ClasseGeneric<T>
    {
        public T Mensagem;
        public void GenericoMensagem(T Nome, T Localidade)
        {
            Console.WriteLine($"Mensagem: {Mensagem}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Localidade: {Localidade}");
        }
    }
}
