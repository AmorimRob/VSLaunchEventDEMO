using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Models
{
    public class Produto
    {
        public string IdProduto { get; private set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public Produto(string nome, decimal preco)
        {
            IdProduto = Guid.NewGuid().ToString();
            Nome = nome;
            Preco = preco;
        }
    }
}
