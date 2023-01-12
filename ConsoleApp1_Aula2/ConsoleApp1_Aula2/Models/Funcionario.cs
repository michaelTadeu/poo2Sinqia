using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Aula2.Models
{
    public abstract class Funcionario
    {
        private string nome;
        private float salario;

        // Construtor
        public Funcionario(string nome, float salario)
        {
            this.nome = nome;
            this.salario = salario;
        }

        public abstract float CalcularProventos();

        public string GetNome()
        {
            return nome;
;       }
        
        public float GetSalario()
        {
            return salario;
        }

    }
}
