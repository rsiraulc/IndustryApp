using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndustryApp.Code.Models;
using Xamarin.Forms;

namespace IndustryApp.Pages
{
    public partial class Expositores : ContentPage
    {
        public Expositores()
        {
            InitializeComponent();
            CargarStands();
        }

        private void CargarStands()
        {
            var stands = new Stands();
            lvExpositores.ItemsSource = stands.GetStands();
        }

        private async void lvExpositores_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var stand = (Stands) e.SelectedItem;
            await Navigation.PushAsync(new Layout(stand));
        }

        private bool _canClose = true;

        protected override bool OnBackButtonPressed()
        {
            if (_canClose)
            {
                Salir();
            }
            return _canClose;
        }

        private async void Salir()
        {
            var answer = await DisplayAlert("IndustryApp", "¿Deseas salir de la aplicación?", "Si", "No");
            if (answer)
            {
                _canClose = false;
                if (Device.OS == TargetPlatform.Android)
                    DependencyService.Get<IAndroidMethods>().CloseApp(); ;
            }
        }
    }
}
