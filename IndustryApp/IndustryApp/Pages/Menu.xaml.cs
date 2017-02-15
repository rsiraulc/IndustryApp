using System;
using System.Collections.Generic;
using IndustryApp.Code;
using IndustryApp.Code.Database;
using IndustryApp.Code.Services;
using MyProject.vCard;
using Xamarin.Forms;
using ZXing.Mobile;
using ZXing.Net.Mobile.Forms;
using IndustryApp.Code.Models;
using IndustryApp.Pages;
using ZXing;

namespace IndustryApp.Pages
{
    public partial class Menu : MasterDetailPage
    {
        private bool _canClose = true;

        public Menu()
        {
            InitializeComponent();
            lvMenu.ItemsSource = new List<Code.Models.MenuItem>
            {
                //new Code.Models.MenuItem {Id = 8, Opcion = "Mis Contactos"},
                new Code.Models.MenuItem {Id = 1, Opcion = "¿Como llegar?"},
                //new Code.Models.MenuItem {Id = 2, Opcion = "Uber Code"},
                new Code.Models.MenuItem {Id = 3, Opcion = "Sponsors"},
                new Code.Models.MenuItem {Id = 6, Opcion = "Agenda MSE 17"},
                new Code.Models.MenuItem {Id = 7, Opcion = "Expositores"},
                new Code.Models.MenuItem {Id = 5, Opcion = "Ruta Expo Maquiladora"},
                new Code.Models.MenuItem {Id = 4, Opcion = "Acerca"}
            };
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

        #region EVENTO MENU

        private async void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                var opcion = (Code.Models.MenuItem) e.SelectedItem;
                switch (opcion.Id)
                {
                    case 1:
                        await Navigation.PushAsync(new Mapa(), true);
                        break;
                    case 2:
                        await Navigation.PushAsync(new UberCode(), true);
                        break;
                    case 3:
                        await Navigation.PushAsync(new Sponsors(), true);
                        break;
                    case 4:
                        await Navigation.PushAsync(new Acerca(), true);
                        break;
                    case 5:
                        await Navigation.PushAsync(new SeleccionEvento(), true);
                        break;
                    case 6:
                        await Navigation.PushAsync(new Agenda(), true);
                        break;
                    case 7:
                        await Navigation.PushAsync(new Expositores(), true);
                        break;
                    case 8:
                        await Navigation.PushAsync(new Contactos(), true);
                        break;
                }

                lvMenu.SelectedItem = null;
            }
        }

        #endregion
    }
}
