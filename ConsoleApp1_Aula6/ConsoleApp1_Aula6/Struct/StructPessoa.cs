using ConsoleApp1_Aula6.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Aula6.Struct
{
    public struct StructPessoa
    {
        public int Idade { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"Nome: {this.Nome}" +
                   $"Email: {this.Email}";
        }
    }
}
