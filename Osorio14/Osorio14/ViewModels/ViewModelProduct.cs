using Osorio14.Models;
using Osorio14.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Osorio14.ViewModels
{
    public class ViewModelProduct : BaseViewModel
    {
        private string color;
        public string Color
        {
            get { return this.color; }
            set { SetValue(ref this.color, value); }
        }

        private DateTime fecha;
        public DateTime Fecha
        {
            get { return this.fecha; }
            set { SetValue(ref this.fecha, value); }
        }

        private string cliente;
        public string Cliente
        {
            get { return this.cliente; }
            set { SetValue(ref this.cliente, value); }
        }

        private double total;
        public double Total
        {
            get { return this.total; }
            set { SetValue(ref this.total, value); }
        }

        private string vendedor;
        public string Vendedor
        {
            get { return this.vendedor; }
            set { SetValue(ref this.vendedor, value); }
        }

        private string filter;
        public string Filter
        {
            get { return this.filter; }
            set { SetValue(ref this.filter, value); }
        }

        private List<Compra> product;
        public List<Compra> Product
        {
            get { return this.product; }
            set { SetValue(ref this.product, value); }
        }


        public ICommand SearchCommand { get; set; }
        public ICommand InsertCommand { get; set; }

        public ViewModelProduct()
        {

            SearchCommand = new Command(() =>
            {
                CompraService service = new CompraService();
                Product = service.GetByText(Filter);


            });

            InsertCommand = new Command(() =>
            {
                CompraService service = new CompraService();
                int newCompraId = service.Get().Count + 1;
                service.Create(new Compra { Fecha = Fecha, Cliente = Cliente, Total = Total, Vendedor = Vendedor, CompraId = newCompraId });

                App.Current.MainPage.DisplayAlert("Success", "Your data are saved", "Ok");
            });
        }
    }
}
