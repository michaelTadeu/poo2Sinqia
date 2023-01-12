using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Aula2_EX2.Interfaces
{
    public interface ILista
    {
        public int Contagem { get; }
        public int Adicionar(int item);

        public bool Remover();
        public bool Remover(int indice);
        public List<int> Dividir(int quantidade);
    }
}
