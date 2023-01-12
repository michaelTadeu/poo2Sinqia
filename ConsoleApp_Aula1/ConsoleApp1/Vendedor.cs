using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Vendedor : Pessoa
    {
        public override void Viajar()
        {
            base.Viajar();
            //Ações do Vendedor para conseguir vendas
        }
    }
}
