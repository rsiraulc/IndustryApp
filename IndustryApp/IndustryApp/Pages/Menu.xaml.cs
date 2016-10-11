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
        public int Id { get; set; }
        public string Opcion { get; set; }
    }

    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);

            ToolbarItems.Add(new ToolbarItem("Nuevo", "add_contacto.png", () =>
            {
                ScanContacto();
            }));

            ToolbarItems.Add(new ToolbarItem("Exportar", "export_contacto.png", () =>
            {
                ExportarContactos();
              
            }));

            lvMenu.ItemsSource = new List<MenuItem>
            {
                new MenuItem {Id = 1, Opcion = "¿Como llegar?"},
                new MenuItem {Id = 2, Opcion = "Uber Code"},
                new MenuItem {Id = 3, Opcion = "Sponsors"},
                new MenuItem {Id = 4, Opcion = "Acerca"}
            };
        }

        private async void ExportarContactos()
        {
            var msg = await DisplayAlert("IndustryApp", "¿Deseas exportar tu lista de contactos a tu correo?", "Si", "No");
            if(msg)
                await DisplayAlert("IndustryApp", "Contactos exportados", "Aceptar");
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

        private async void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                var opcion = (MenuItem) e.SelectedItem;
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
                }

                lvMenu.SelectedItem = null;
            }
        }
    }
}
