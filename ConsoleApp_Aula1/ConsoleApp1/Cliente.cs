using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Cliente : Pessoa
    {
        //Propriedades
        public int clienteId;
        public string nomeCliente;
        private decimal limiteCredito;
        private int quantidadeProdutos;
        public int produtosAdquiridos;
        public readonly bool eClienteEspecial;

        //public Cliente(int quantidade)
        //{
        //    if (produtosAdquiridos < quantidade)
        //    {
        //        eClienteEspecial = false;
        //    } else
        //    {
        //        eClienteEspecial = true;
        //    }
        //}

        public Cliente(): this("default", 99)
        {
        }

        public Cliente(string nome, int idenficacao)
        {
            this.nomeCliente = nome;
            this.clienteId = idenficacao;
        }

        //public bool EclienteEspecial()
        //{
        //    if (produtosAdquiridos < 250)
        //    {
        //        return false;
        //    }
        //    return true;
        //}

        public void ComprarEspecial()
        {
            //AÇÃO
        }

        public void DefinirProdutosAdquiridos(int quantidade)
        {
            produtosAdquiridos = quantidade;
        }

        public void DefinirProdutosAdquiridos(int quantidade, bool clienteModificado)
        {
            if (clienteModificado)
            {
                produtosAdquiridos = quantidade;
            }
        }

        public void DefinirProdutosAdquiridos()
        {
            produtosAdquiridos = RecuperarProdutos(clienteId);
        }

        public void Comprar(int idProduto)
        {
            //BuscarProduto
        }

    }



    //public class Pessoa
    //{
    //    private string nome;
    //    private int cpf;
    //    ...
    //}
}
