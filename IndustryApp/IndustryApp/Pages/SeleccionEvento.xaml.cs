using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;
using ZXing.Net.Mobile.Forms;

using Xamarin.Forms;
using ZXing.Mobile;

namespace IndustryApp.Pages
{
    public partial class SeleccionEvento : ContentPage
    {
        public SeleccionEvento()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
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

        private async void btnBajaMak_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EventoDetalle("BajaMak"));
        }

        private async void btnHermosillo_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EventoDetalle("Hermosillo Transforma"));
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Menu());
        }
    }
}
