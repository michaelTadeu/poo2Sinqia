using System.Globalization;
using System;
using System.Reflection;
using ConsoleApp1_Aula5.Models;

namespace ConsoleApp1_Aula5
{
    class Program
    {
        public static void Main(string[] args)
        {
            // ##### Exemplo Inicial
            ////bool IsEqual = Calcular.VerificarIgualdade(10, 20);
            ////bool IsEqual = Calcular.VerificarIgualdade("ABC", "ABC");
            ////bool IsEqual = Calcular.VerificarIgualdade(10.5, 20.5);
            ////bool IsEqual = Calcular.VerificarIgualdade<int>(10, 20);
            ////bool IsEqual = Calcular.VerificarIgualdade<string>("ABC", "ABC");
            ////bool IsEqual = Calcular.VerificarIgualdade<double>(10.5, 20.4);
            //var teste1 = "1";
            //var teste2 = 1;
            //bool IsEqual = Calcular.VerificarIgualdade<object>(teste1, teste2);

            //if (IsEqual)
            //{
            //    Console.WriteLine("Ambos são inteiros Iguais");
            //} else
            //{
            //    Console.WriteLine("Ambos não são inteiros iguais");
            //}
            //Exemplo Inicial ######

            //Exemplo List (Generic)
            //List<Cliente> listaCliente = new List<Cliente>();

            //Cliente cliente = new Cliente(1, "Camila");
            //Cliente cliente2 = new Cliente(2, "Pedro");

            //listaCliente.Add(cliente);
            //listaCliente.Add(cliente2);
            //listaCliente.Remove(cliente2);

            //Exemplo classe Generic
            //Console.WriteLine("Exemplo Classe Generic");
            //ClasseGeneric<string> classeGeneric = new ClasseGeneric<string>
            //{
            //    Mensagem = "Olá"
            //};

            //classeGeneric.GenericoMensagem("José", "São Paulo");

            Stack<Vendedor> pilhaVendedor = new Stack<Vendedor>();

            Vendedor novoVendedor0 = new Vendedor(4, "Jorge");
            Vendedor novoVendedor1 = new Vendedor(5, "Pedro");

            pilhaVendedor.Push(novoVendedor0);
            pilhaVendedor.Push(novoVendedor1);
            pilhaVendedor.Pop();

            Queue<Vendedor> filaVendedor = new Queue<Vendedor>();
            Vendedor novoVendedor = new Vendedor(2, "Bernardo");

            filaVendedor.Enqueue(novoVendedor);
            filaVendedor.Dequeue();

            LinkedList<Vendedor> listaEncadVendedor = new LinkedList<Vendedor>();

            Vendedor novoVendedor2 = new Vendedor(4, "Bernardo");
            Vendedor novoVendedor3 = new Vendedor(5, "Maria");
            Vendedor novoVendedor4 = new Vendedor(6, "Andréia");


            listaEncadVendedor.AddHead(novoVendedor2);
            listaEncadVendedor.AddTail(novoVendedor3);
            listaEncadVendedor.AddFirst(novoVendedor3);

            //Menu Consulta = Head -> Menu Profissionais = Tail -> Menu Consultorio = tail

            //Pedro
            //Jorge

            //Jorge, Pedro

            Console.ReadKey();
        }       
    }
}

