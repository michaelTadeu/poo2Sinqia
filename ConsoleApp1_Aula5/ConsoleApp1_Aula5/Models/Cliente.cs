using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Aula5.Models
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string NomeCLiente { get; set; }

        public Cliente(int idCliente, string nomeCLiente)
        {
            IdCliente = idCliente;
            NomeCLiente = nomeCLiente;
        }
    }
}
