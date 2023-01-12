using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Aula2.Models
{
    public class FuncionarioPadrao : Funcionario
    {
       // Construtor
       public FuncionarioPadrao(string nome, float salario) : base(nome, salario)
        {

        }

        // Implemente método abstrato
        public override float CalcularProventos()
        {
            return GetSalario();
        }
    }
}
