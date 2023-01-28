using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Aula8.Interfaces
{
    public interface Cliente : ICadastro
    {
        void validarDados();
        void EnviarEmail();
    }
}
