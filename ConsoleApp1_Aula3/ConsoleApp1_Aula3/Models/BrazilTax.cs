using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1_Aula3.Intefaces;

namespace ConsoleApp1_Aula3.Models
{
    public class BrazilTax : ITax, ISeguro
    {
        public double Tax(double amount)
        {
            if (amount <= 100.00)
            {
                return amount * 0.2;
            } else
            {
                return amount * 0.12;
            }
        }

        public double TaxRoubo(int gravidade, double amount)
        {
            if (gravidade == 1)
            {
                return gravidade + amount * 0.1; 
            } else if (gravidade == 2)
            {
                return gravidade + amount * 0.2;
            } else
            {
                return gravidade + amount * 0.5;
            }
        }
    }
}
