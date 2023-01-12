using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1_Aula2_EX2.Interfaces;

namespace ConsoleApp1_Aula2_EX2.Models
{
    public class FilaDeMercado : ILista, ICaixa
    {
        public int Contagem => throw new NotImplementedException();

        public int Adicionar(int item)
        {
            throw new NotImplementedException();
        }

        public bool Remover()
        {
            throw new NotImplementedException();
        }

        public bool Remover(int indice)
        {
            throw new NotImplementedException();
        }

        public List<int> Dividir(int quantidade)
        {
            throw new NotImplementedException();
        }

        public int Somar()
        {
            throw new NotImplementedException();
        }
    }
}
