using System.Globalization;
using ConsoleApp1_Aula4.Models;
using System;
using System.Reflection;

namespace ConsoleApp1_Aula4
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Type t = typeof(Program);

            //Console.WriteLine("Name: {0}", t.Name);
            //Console.WriteLine("Full Name: {0}", t.FullName);
            //Console.WriteLine("Namespace: {0}", t.Namespace);
            //Console.WriteLine("Base: {0}", t.BaseType);

            //try
            //{
            //    // Ações
            //    Type t = typeof(Program);
            //    Console.WriteLine("Name: {0}", t.FullName);
            //}
            //catch (Exception)
            //{

            //    throw;
            //}

            //Assembly executing = Assembly.GetExecutingAssembly();

            //Type[] types = executing.GetTypes();

            //foreach (var item in types)
            //{
            //    Console.WriteLine("Class : {0}", item.Name);

            //    MethodInfo[] metodos = item.GetMethods();
            //    foreach (var metodo in metodos)
            //    {
            //        Console.WriteLine("--> Método : {0},", metodo.Name);

            //        ParameterInfo[] parametros = metodo.GetParameters();
            //        foreach (var parametro in parametros)
            //        {
            //            Console.WriteLine("----> Parâmetro : {0} Tipo: {1}",
            //                parametro.Name, parametro.ParameterType);
            //        }
            //    }
            //}

            var cliente = new Cliente()
            {
                IdCliente = 10,
                Nome = "Pedro",
                Endereco = "Rua dos ETs, 256"
            };

            var produto = new Produto()
            {
                IdProduto = 1,
                Nome = "Copo",
                Descricao = "Copo de vidro",
                Estoque = 2500,
                Preco = 1.99M
            };

            var pedido = new Pedido()
            {
                IdPedido = 1,
                ClienteId = 10,
                DataPedido = DateTime.Now
            };

            Console.WriteLine("*** Logando Informações sem Reflection ***");
            LogarSemReflection(cliente, produto, pedido);
            Console.WriteLine("*** Logando Informações com Reflection ***");
            LogarComReflection(cliente, produto, pedido);
            Console.ReadKey();

        }

        public static void LogarSemReflection(Cliente cliente, Produto produto, Pedido pedido)
        {
            LogSemReflection.LogClientes(cliente);
            LogSemReflection.LogProdutos(produto);
            LogSemReflection.LogPedidos(pedido);
        }

        public static void LogarComReflection(Cliente cliente, Produto produto, Pedido pedido)
        {
            LogComReflection.Log(cliente);
            LogComReflection.Log(produto);
            LogComReflection.Log(pedido);
        }

    }
}

