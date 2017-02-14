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
                new Code.Models.MenuItem {Id = 2, Opcion = "Uber Code"},
                new Code.Models.MenuItem {Id = 3, Opcion = "Sponsors"},
                new Code.Models.MenuItem {Id = 6, Opcion = "Agenda MSE 17"},
                new Code.Models.MenuItem {Id = 7, Opcion = "Expositores"},
                new Code.Models.MenuItem {Id = 5, Opcion = "Ruta Expo Maquiladora"},
                new Code.Models.MenuItem {Id = 4, Opcion = "Acerca"}
            };
        }
        public async void ScanContacto()
        {
            var options = new MobileBarcodeScanningOptions
            {
                AutoRotate = false,
                UseFrontCameraIfAvailable = false,
                TryHarder = true,
                PossibleFormats = new List<ZXing.BarcodeFormat> { ZXing.BarcodeFormat.QR_CODE },
            };

            var scanPage = new ZXingScannerPage(options)
            {
                DefaultOverlayTopText = string.Empty,
                DefaultOverlayBottomText = string.Empty,
                DefaultOverlayShowFlashButton = true,
                Title = "Escanea Código QR",
                IsScanning = true,
                IsAnalyzing =  true
            };

            await Navigation.PushModalAsync(scanPage, true);

            scanPage.OnScanResult += (result) =>
            {
                scanPage.IsScanning = false;
                scanPage.IsAnalyzing = false;
                
                if (result.Text.Contains("VCARD"))
                {
                    Device.BeginInvokeOnMainThread(async () =>
                    {
                        await Navigation.PopModalAsync(true);
                        var reader = new vCardReader();
                        reader.ParseLines(result.Text);
                        var contacto = new Code.Models.Contactos
                        {
                            Correo = reader.Emails[0].address,
                            Empresa = reader.Org,
                            Nombre = reader.FormattedName,
                            Apellido = reader.Surname,
                            Telefono = reader.Phones[0].number,
                            IdUsuario = 1
                        };

                        var data = new DataAccess();
                        var c = new Contactos();
                        var response = data.InsertContacto(contacto);
                        await DisplayAlert("IndustryApp", response.Message, "Aceptar");
                        
                        //await Navigation.PushAsync(new Contactos(), true);
                        //await Navigation.PopAsync();
                        //await Navigation.PushAsync(new DetalleContacto(response.Contacto));

                    });
                    scanPage.PauseAnalysis();
                }
                else
                {
                    scanPage.PauseAnalysis();
                    DisplayAlert("IndustryApp", "Favor de leer un código valido", "Aceptar");
                }
            };           
        }

        private async void ExportarContactos()
        {
            var data = new DataAccess();
            if(data.GetTotalContactos() == 0)
                await DisplayAlert("IndustryApp", "Por el momento no cuentas con contactos registrados para importar", "Aceptar");
            else
            {
                var msg = await DisplayAlert("IndustryApp", "¿Deseas exportar tu lista de contactos a tu correo?", "Si", "No");
                if (!msg) return;
                var exp = new ExportarContactos();
                await exp.EnviarArchivo();
            }
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
                        await Navigation.PushAsync(new Mapa());
                        break;
                    case 2:
                        await Navigation.PushAsync(new UberCode());
                        break;
                    case 3:
                        await Navigation.PushAsync(new Sponsors());
                        break;
                    case 4:
                        await Navigation.PushAsync(new Acerca());
                        break;
                    case 5:
                        await Navigation.PushAsync(new SeleccionEvento());
                        break;
                    case 6:
                        await Navigation.PushAsync(new Agenda());
                        break;
                    case 7:
                        await Navigation.PushAsync(new Expositores());
                        break;
                    case 8:
                        await Navigation.PushAsync(new Contactos());
                        break;
                }

                lvMenu.SelectedItem = null;
            }
        }
#endregion
    }
}
