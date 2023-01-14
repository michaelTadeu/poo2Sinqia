using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1_Aula3.Intefaces;

namespace ConsoleApp1_Aula3.Models
{
    public class Cliente : Banco, IConta, IPessoa, IProduto
    {
        //Utilização dos metódos das Interfaces
        //IConta.Saque();
        //IPessoa.Cadastro();
        //IProduto.BuscaProduto();
    }
}
