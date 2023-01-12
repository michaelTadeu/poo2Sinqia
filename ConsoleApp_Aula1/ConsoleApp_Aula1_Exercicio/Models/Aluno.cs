using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Aula1_Exercicio
{
    public class Aluno : Pessoa
    {
        public Aluno()
        {
        }

        public Aluno(string pnome, int pidade) : base(pnome, pidade)
        {
        }

        public void IrParaEscola()
        {
            Console.WriteLine("O aluno {0} está indo para escola.", this.nome);
        }
    }
}
