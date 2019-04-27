using App1.Models;
using App1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaPedidosPage : ContentPage
    {
        public ListaPedidosPage()
        {
            InitializeComponent();
            BindingContext = new ListaPedidosPageViewModel();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var pedidoSelecionado = e.SelectedItem as Pedido;
            App.Current.MainPage.Navigation.PushAsync(new DetalhesPedidoPage(pedidoSelecionado));
        }
    }
}