using ConsoleApp1_Aula6.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Aula6.Models
{
    public class Faculdade
    {
        //private EventosTech _eventosTech = null;
        //private EventosCulturais _eventosCulturais = null;
        //private EventosFutebol _eventosFutebol = null;

        private IEvento _eventos = null;
        LocalizacaoEvento locEvento = new LocalizacaoEvento();
        public IEvento meuEvento
        {
            set
            {
                _eventos = value;
            }
        }
        //private List<IEvento> _listaEventos = null;

        //public Faculdade()
        //{
        //    _eventosTech = new EventosTech();
        //    _eventosCulturais = new EventosCulturais();
        //    _eventosFutebol = new EventosFutebol();
        //}

        //public Faculdade(EventosTech evento, EventosCulturais eventoC, EventosFutebol)
        //{
        //    _eventosTech = new EventosTech();
        //    _eventosCulturais = new EventosCulturais();
        //    _eventosFutebol = new EventosFutebol();
        //}

        public Faculdade(int index)
        {
            this._eventos = locEvento.LocaEventos(index);
        }

        public Faculdade(IEvento iEvento)
        {
            this._eventos = iEvento;
        }

        //public Faculdade(List<IEvento> listaIEventos)
        //{
        //    foreach (var item in listaIEventos)
        //    {
        //        this._eventos.Add(item);
        //    }

        //}

        //public void GetEventos()
        //{
        //    _eventosTech.DetalhesEvento();
        //    _eventosCulturais.DetalhesEvento();
        //    _eventosFutebol.DetalhesEvento();
        //}

        //public void GetEventos()
        //{
        //    this._eventos.DetalhesEvento();
        //}
        public void GetEventos(IEvento meuEvento)
        {
            this._eventos = meuEvento;
        }

        public void GetEventos()
        {
        }

    }
}
