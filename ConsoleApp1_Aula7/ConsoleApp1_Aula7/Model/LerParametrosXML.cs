using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Aula7.Model
{
    public class LerParametrosXML : LerParamentros
    {
        public override string GetBDConexaoString()
        {
            string bdConexao = "Conexão via arquivo XML";
            //Implementar o método para buscar a string do BD
            bdConexao = AjustarDetalhesParamentos(bdConexao);

            return bdConexao;
        }
    }
}
