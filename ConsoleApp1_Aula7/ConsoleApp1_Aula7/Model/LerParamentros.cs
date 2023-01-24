using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Aula7.Model
{
    public abstract class LerParamentros
    {
        public abstract string GetBDConexaoString();

        public string AjustarDetalhesParamentos(string conexao)
        {
            return conexao + " - Floricultura";
        }
    }
}
