using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Aula5.Models
{
    public class Vendedor
    {
        public int IdVendedor { get; set; }
        public string NomeVendedor { get; set; }

        public Vendedor(int idVendedor, string nomeVendedor)
        {
            IdVendedor = idVendedor;
            NomeVendedor = nomeVendedor;
        }
    }
}
