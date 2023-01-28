using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Aula8.Models
{
    public class Email
    {
        public string EnderecoEmail { get; set; }
        public bool Validar()
        {
            return EnderecoEmail.Contains("@");
        }
    }
}
