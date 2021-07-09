using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FirmaSQLite
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        Firmas itemFirmas = new Firmas();

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            try
            {
                ListaSGNT.ItemsSource = await App.InstanciaDB.ObtenerFirmas();
            }
            catch (Exception ex)
            {

            }
        }

        private async void BtnFirma_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PadPage());
        }

        private async void ListaFirmas_ItemTapped(object sender, ItemTappedEventArgs e)
        {

            itemFirmas = (Firmas)e.Item;

            var jpg = itemFirmas.FirmaContent;
            var nombre = itemFirmas.nombreFirma;
            var descripcion = itemFirmas.descripcionFirma;


            await Navigation.PushAsync(new firmasPage(jpg, nombre, descripcion));




        }
    }
}
