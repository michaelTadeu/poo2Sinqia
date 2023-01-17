using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Aula4.Models
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public int ClienteId { get; set; }
        public DateTime DataPedido { get; set; }
    }
}
