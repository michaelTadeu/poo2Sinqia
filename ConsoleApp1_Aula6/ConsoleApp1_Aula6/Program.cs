using System.Globalization;
using System;
using System.Reflection;
using ConsoleApp1_Aula6.Models;
using ConsoleApp1_Aula6.Struct;
using ConsoleApp1_Aula6.Interfaces;
using System.Collections;

namespace ConsoleApp1_Aula6
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Restrição por class
            DataStore<string> store1 = new DataStore<string>();
            DataStore<Pedido> store2 = new DataStore<Pedido>();
            DataStore<IPessoa> store3 = new DataStore<IPessoa>();
            DataStore<IEnumerable> store4 = new DataStore<IEnumerable>();
            DataStore<ArrayList> store5 = new DataStore<ArrayList>();
            //DataStore<int> store6 = new DataStore<int>();

            //Restrição por struct
            DataStore1<int> store7 = new DataStore1<int>();
            DataStore1<Int32> store8 = new DataStore1<Int32>();
            DataStore1<char> store9 = new DataStore1<char>();
            DataStore1<StructPessoa> store10 = new DataStore1<StructPessoa>();
            //DataStore1<string> store11 = new DataStore1<string>();

            //StructPessoa structPessoa = new();
            //structPessoa.Cpf = "111.111.111-11";
            //structPessoa.Nome = "Teste";

            //Pedido pedido = new Pedido()
            //{
            //    IdPedido = 1,
            //    ItemPedido = "Coca-Cola"
            //};

            //Restrição por class, new()
            DataStore2<Diretor> store12 = new DataStore2<Diretor>();
            DataStore2<ArrayList> store13 = new DataStore2<ArrayList>();
            //DataStore2<Int32> store14 = new DataStore2<Int32>();
            //DataStore2<string> store15 = new DataStore2<string>();
            //DataStore2<IPessoa> store16 = new DataStore2<IPessoa>();
            //DataStore2<IEnumerable> store17 = new DataStore2<IEnumerable>();
            //DataStore2<StructPessoa> store18 = new DataStore2<StructPessoa>();


            // Restrição por tipo classe especifica, classe abstrata, inteface
            DataStore3<Diretor> store19 = new DataStore3<Diretor>();
            //DataStore3<ArrayList> store20 = new DataStore3<ArrayList>();

            Funcionario<Vendedor> listaVendedor = new Funcionario<Vendedor>();
            //Funcionario<Diretor> listaVendedor1 = new Funcionario<Diretor>();

            // Injeção de Dependência por construtor
            //EventosFutebol eventoF = new EventosFutebol();
            //eventoF.NomeEvento = "Copa do Brasil";
            //Faculdade evento = new Faculdade(eventoF);
            //evento.GetEventos();

            // Injeção de Dependência por propriedade (Campo)
            //Faculdade faculdadeP = new Faculdade();
            //faculdadeP.meuEvento = new EventosTech();

            // Injeção de Dependência por método
            //Faculdade faculdadeM = new Faculdade();
            //faculdadeM.GetEventos(new EventosCulturais());

            // Injeção de Dependência por Service Locator
            Faculdade faculdade = new Faculdade(1);
            faculdade.GetEventos();

            Console.ReadKey();
        }
    }
}

