using ConsoleApp1_Aula8.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Aula8.Models
{
    public class CadastroCliente : Interfaces.Cliente
    {
        public void validarDados()
        {
            //validar
        }
        public void SalvarBanco()
        {
            //Insert no BD
        }
        public void EnviarEmail()
        {
            //Enviar E-mail p/ cliente
        }
    }

}
