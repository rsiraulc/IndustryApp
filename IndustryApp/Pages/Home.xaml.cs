using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace IndustryApp.Pages
{
    public partial class Home : TabbedPage
    {
        private bool _canClose = true;
        public Home()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
        }

        protected override bool OnBackButtonPressed()
        {
            if (_canClose)
                Salir();

            return _canClose;
        }

        private async void Salir()
        {
            var answer = await DisplayAlert("IndustryApp", "¿Deseas salir de la aplicación?", "Si", "No");
            if (answer)
            {
                _canClose = false;
                if (Device.OS == TargetPlatform.Android)
                    DependencyService.Get<IAndroidMethods>().CloseApp();
            }
        }
    }
}
