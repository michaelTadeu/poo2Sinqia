using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Aula4.Models
{
    public class LogSemReflection
    {
        public static void LogProdutos(Produto produto)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Log do Produto");
            builder.AppendLine("Data: " + DateTime.Now);
            builder.AppendLine("Id: " + produto.IdProduto);
            builder.AppendLine("Nome: " + produto.Nome);
            builder.AppendLine("Descrição: " + produto.Descricao);
            builder.AppendLine("Estoque: " + produto.Estoque);
            ImprimirLog(builder.ToString());
            //SalvarLog(builder.ToString());


            //StringBuilder builder = new StringBuilder();
            //builder.AppendLine("Oi");
            //builder.AppendLine("Paulo");

            //var string1 = "Oi";
            //var string2 = "Paulo";
            //var string3 = string1 + string2;

        }

        public static void LogPedidos(Pedido pedido)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Log do Pedido");
            builder.AppendLine("Data: " + DateTime.Now);
            builder.AppendLine("Id: " + pedido.IdPedido);
            builder.AppendLine("Nome: " + pedido.ClienteId);
            builder.AppendLine("Descrição: " + pedido.DataPedido);
            ImprimirLog(builder.ToString());
        }

        public static void LogClientes(Cliente cliente)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Log do Cliente");
            builder.AppendLine("Data: " + DateTime.Now);
            builder.AppendLine("Id: " + cliente.IdCliente);
            builder.AppendLine("Nome: " + cliente.Nome);
            builder.AppendLine("Descrição: " + cliente.Endereco);
            ImprimirLog(builder.ToString());
        }

        public static void ImprimirLog(string texto)
        {
            Console.WriteLine(texto);
        }

        public static void SalvarLog(string texto)
        {
            // Salvar Log
        }
    }
}
