using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Aula7.Model
{
    public class LerParamentros_OLD
    {
        public virtual string GetBDConexaoString()
        {
            string bdConexao = "Conexão via arquivo JSON";
            //Implementar o método para buscar a string do BD
            bdConexao = AjustarDetalhesParamentos(bdConexao);

            return bdConexao;
        }

        public string AjustarDetalhesParamentos(string conexao)
        {
            return conexao + " - Floricultura";
        }
    }
}
