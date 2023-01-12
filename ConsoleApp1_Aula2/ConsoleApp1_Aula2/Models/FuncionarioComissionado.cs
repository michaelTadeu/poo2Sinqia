using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Aula2.Models
{
    public class FuncionarioComissionado : Funcionario
    {
        public float vendas { get; set; }
        public float percentual { get; set; }

        public FuncionarioComissionado(string nomeTeste, float salario, float vendas, float percentual) : base(nomeTeste, salario)
        {
            this.vendas = vendas;
            this.percentual = percentual;
        }

        // Implemente método abstrato
        public override float CalcularProventos()
        {
            return GetSalario() + CalcularComissao();
        }

        private float CalcularComissao()
        {
            return vendas * (percentual / 100);
        }
    }
}
