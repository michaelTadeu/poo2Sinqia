using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Aula6.Models
{
    public class Pedido
    {
        private ItemPedido _oItemPedido;
        public ItemPedido OitemPedido
        {
            get { return _oItemPedido; }
            set { _oItemPedido = value; }
        }
        //public void CriarPedido()
        //{
        //    List<ItemPedido> oItemPedido = new List<ItemPedido>();
        //}

        public void CriarPedido()
        {
            if (OitemPedido == null)
            {
                throw new Exception("Não Existe Itens para esse Pedido");
            }
        }
    }
}