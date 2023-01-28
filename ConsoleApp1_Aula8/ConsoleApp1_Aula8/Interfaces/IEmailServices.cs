using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Aula8.Interfaces
{
    public interface IEmailServices
    {
        void Enviar(string de, string para, string assunto, string mensagem);
    }
}
