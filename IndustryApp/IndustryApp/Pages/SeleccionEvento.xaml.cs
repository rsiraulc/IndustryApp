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
