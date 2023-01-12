using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Aula1_Exercicio
{
    public class Professor : Pessoa
    {
        public Professor()
        {
        }

        public Professor(string pnome, int pidade) : base(pnome, pidade)
        {
        }

        public void Explicar(string assunto)
        {
            Console.WriteLine("O professor {0} está explicando sobre {1}.", this.nome, assunto);
        }
    }
}
