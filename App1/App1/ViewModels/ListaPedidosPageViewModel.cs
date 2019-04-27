using App1.Models;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace App1.ViewModels
{
    public class ListaPedidosPageViewModel : BaseViewModel
    {
        public ObservableCollection<Pedido> Pedidos { get; set; }

        public ListaPedidosPageViewModel()
        {
            CarregarListaDePedidos();
        }

        private void CarregarListaDePedidos()
        {
            Pedidos = new ObservableCollection<Pedido>();
            Pedidos.Add(new Pedido(new List<Produto>()
            {
                new Produto("Celular", 2000M),
                new Produto("Televisão", 1000M),
                new Produto("Notebook", 3500M),
                new Produto("Fone de ouvido", 150M),
                new Produto("Projetor", 500M)
            }));

            Pedidos.Add(new Pedido(new List<Produto>()
            {
                new Produto("Projetor", 500M)
            }));

            Pedidos.Add(new Pedido(new List<Produto>()
            {
                new Produto("Celular", 2000M),
                new Produto("Televisão", 1000M)
            }));

        }
    }
}
