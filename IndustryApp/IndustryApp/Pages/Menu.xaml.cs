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

namespace IndustryApp.Pages
{
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);

            ToolbarItems.Add(new ToolbarItem("Nuevo", "add_contacto.png", ScanContacto));

            ToolbarItems.Add(new ToolbarItem("Exportar", "export_contacto.png", ExportarContactos));

            lvMenu.ItemsSource = new List<Code.Models.MenuItem>
            {
                new Code.Models.MenuItem {Id = 1, Opcion = "¿Como llegar?"},
                new Code.Models.MenuItem {Id = 2, Opcion = "Uber Code"},
                new Code.Models.MenuItem {Id = 3, Opcion = "Sponsors"},
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
                DefaultOverlayShowFlashButton = true
            };

            scanPage.Title = "Escanea Código QR";
            await Navigation.PushAsync(scanPage);

            scanPage.OnScanResult += (result) =>
            {
                scanPage.IsScanning = false;


                if (result.Text.Contains("VCARD"))
                {
                    Device.BeginInvokeOnMainThread(async () =>
                    {
                        await Navigation.PopAsync();
                        var reader = new vCardReader();
                        reader.ParseLines(result.Text);
                        var cont = new Contactos();
                        cont.AddContacto(reader);
                        await Navigation.PushAsync(new Menu());
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
                if (msg)
                {
                    var exp = new ExportarContactos();
                    await exp.EnviarArchivo();
                }
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
                }

                lvMenu.SelectedItem = null;
            }
        }
#endregion
    }
}
