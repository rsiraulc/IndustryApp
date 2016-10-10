using System;
using System.Collections.Generic;
using IndustryApp.Code.Services;
using MyProject.vCard;
using Xamarin.Forms;
using ZXing.Mobile;
using ZXing.Net.Mobile.Forms;

namespace IndustryApp.Pages
{
    public class MenuItem
    {
        public string Nombre { get; set; }
    }

    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);

            //var np = new NavigationPage(this);
            //np.BarBackgroundColor = Color.FromHex("31B3B3");

            ToolbarItems.Add(new ToolbarItem("Nuevo", "add_contacto.png", () =>
            {
                ScanContacto();
            }));

            ToolbarItems.Add(new ToolbarItem("Exportar", "export_contacto.png", () =>
            {
                ExportarContactos();
              
            }));
        }

        private async void ExportarContactos()
        {
            var msg = await DisplayAlert("IndustryApp", "¿Deseas exportar tu lista de contactos a tu correo?", "Si", "No");
            if(msg)
                await DisplayAlert("IndustryApp", "Contactos exportados", "Aceptar");
        }

        private async void btnSponsor_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sponsors());
        }

        private async void btnUber_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UberCode());
        }

        private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var x = (MenuItem) e.SelectedItem;
            DisplayAlert("IndustryApp", x.Nombre, "OK", "Cancel");
        }

        private async void btnAcerca_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Acerca());
        }

        public async void ScanContacto()
        {
            var options = new MobileBarcodeScanningOptions
            {
                AutoRotate = false,
                UseFrontCameraIfAvailable = false,
                TryHarder = true,
                PossibleFormats = new List<ZXing.BarcodeFormat> { ZXing.BarcodeFormat.QR_CODE},
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
                
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await Navigation.PopAsync();
                    var x = new vCardReader();
                    x.ParseLines(result.Text);
                    AddContacto(x);
                });

                scanPage.PauseAnalysis();
            };
        }

        private async void AddContacto(vCardReader _contacto)
        {
            var contactoService = new ContactoService();
            var contacto = new Code.Models.Contactos
            {
                Correo = _contacto.Emails[0].address,
                Empresa = _contacto.Org,
                FechaRegistro = DateTime.Now,
                Id = contactoService.GetListaCount() + 1,
                Nombre = _contacto.GivenName + " " + _contacto.Surname,
                IdUsuario = 1,
                Telefono = _contacto.Phones[0].number
            };

            if (contactoService.AddContacto(contacto))
            {
                await DisplayAlert("IndustryApp", _contacto.FormattedName + " ha sido agregado a tu lista de contactos", "Ok");
                var x = new Contactos();
            }
            else
                await DisplayAlert("IndustryApp", "Este contacto ya existe en tu lista", "Ok");


        }

        private async void btnComoLlegar_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Mapa());
        }
    }
}
