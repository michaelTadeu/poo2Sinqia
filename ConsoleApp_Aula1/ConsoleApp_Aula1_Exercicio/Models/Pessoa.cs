using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Aula1_Exercicio
{
    public class Pessoa
    {
        public string nome { get; set; }
        public int idade { get; set; }

        public Pessoa()
        {
        }

        public Pessoa(string pnome, int pidade)
        {
            this.nome = pnome;
            this.idade = pidade;
        }

        public void Cumprimentar()
        {
            Console.WriteLine("Olá, meu nome é {0}.", this.nome);
        }

        public void DizerIdade()
        {
            Console.WriteLine("Tenho {0} anos de idade.", this.idade);
        }
    }
}
