using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Produto
    {
        public string nome { get; set; }
        public int numeroProdutosCliente;

        public double _valorUnitario;
        public double valorServico
        {
            get { 
                return _valorUnitario; 
            }

            set
            {
                if (value > 0)
                {
                    _valorUnitario = value;
                }
            }
        }
    }
}
