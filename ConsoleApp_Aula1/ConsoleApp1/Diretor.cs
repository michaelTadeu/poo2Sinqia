using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Diretor : Pessoa
    {
        public override void Viajar()
        {
            base.Viajar();
            //Ações Viajar para parcerias
        }
    }
}
