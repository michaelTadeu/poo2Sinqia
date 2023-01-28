using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Aula8.Models
{
    public class Cpf
    {
        public string NumeroCpf { get; set; }

        public bool Validar()
        {
            return NumeroCpf.Length == 11;
        }
    }
}
