using ConsoleApp1_Aula6.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Aula6.Models
{
    public class LocalizacaoEvento
    {
        public IEvento LocaEventos(int index)
        {
            if(index == 1)
            {
                return new EventosFutebol();
            } else if (index == 2)
            {
                return new EventosTech();
            } else 
            {
                return new EventosCulturais();
            }
        }
    }
}
