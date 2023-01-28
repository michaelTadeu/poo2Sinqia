using ConsoleApp1_Aula8.Interfaces;
using ConsoleApp1_Aula8.Models;
using ConsoleApp1_Aula8.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cliente = ConsoleApp1_Aula8.Models.Cliente;

namespace ConsoleApp1_Aula8.Services
{
    public class ClienteServices : IClienteServices
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IEmailServices _emailServices;

        public ClienteServices(
            IEmailServices emailServices,
            IClienteRepository clienteRepository)
        {
            _emailServices = emailServices;
            _clienteRepository = clienteRepository;
        }

        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.Validar())
                return "Dados inválidos";

            _clienteRepository.AdicionarCliente(cliente);

            _emailServices.Enviar("empresa@empresa.com", cliente.Email.Endereco, "Bem Vindo", "Parabéns está Cadastrado");

            return "Cliente cadastrado com sucesso";
        }

        public string AdicionarCliente(Interfaces.Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }

    public class TesteDip
    {
        public TesteDip()
        {
            var cliService = new ClienteServices(new EmailService(), new ClienteRepository2());
        }
    }
}
