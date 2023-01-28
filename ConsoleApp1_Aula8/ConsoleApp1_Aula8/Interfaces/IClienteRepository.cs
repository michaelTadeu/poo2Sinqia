using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1_Aula8.Models;

namespace ConsoleApp1_Aula8.Interfaces
{
    public interface IClienteRepository
    {
        void AdicionarCliente(Cliente cliente);
    }
}
