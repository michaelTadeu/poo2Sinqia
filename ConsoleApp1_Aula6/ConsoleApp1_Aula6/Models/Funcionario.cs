using ConsoleApp1_Aula6.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Aula6.Models
{
	public class Funcionario<T> where T : Vendedor, IPessoa, IProduto, new()
	{
		private int idFunc;
		static List<T> listaFuncionarios = new List<T>();
		public void Adicionar(T elemento) 
		{
		}
		public void Remover(T elemento) 
		{ 
		}
	}

}
