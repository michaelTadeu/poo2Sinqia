using ConsoleApp1_Aula6.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Aula6.Models
{
    public class EventosFutebol : IEvento
    {
        //public string NomeEvento { get; set; } 

        public void DetalhesEvento()
        {
            Console.WriteLine("Detalhes do Evento de Futebol");
        }
    }
}
