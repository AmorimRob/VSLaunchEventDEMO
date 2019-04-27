using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace App1.Models
{
    public class Pedido
    {
        public string IdPedido { get; private set; }
        public List<Produto> Produtos { get; private set; }
        public DateTime DataPedido { get; private set; }

        private decimal valor;

        public decimal Valor
        {
            get { return Produtos.Sum(x => x.Preco); }
            set { valor = value; }
        }

        public Pedido(List<Produto> produtos)
        {
            IdPedido = Guid.NewGuid().ToString();
            Produtos = produtos;
            DataPedido = DateTime.Now;
        }
    }
}
