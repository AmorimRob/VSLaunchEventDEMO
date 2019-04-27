using App1.Models;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace App1.ViewModels
{
    public class DetalhesPedidosPageViewModel : BaseViewModel
    {
        private Pedido pedidoSelecionado;

        public Pedido PedidoSelecionado
        {
            get { return pedidoSelecionado; }
            set { pedidoSelecionado = value; OnPropertyChanged(); }
        }


        public DetalhesPedidosPageViewModel(Pedido pedido)
        {
            PedidoSelecionado = pedido;
        }
    }
}
