using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;
using Xamarin.Forms;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Android.Provider;
using IndustryApp.Code;
using IndustryApp.IndustryAppWS;
using IndustryApp.weather;
using Newtonsoft.Json;
using Org.Apache.Http.Client.Params;
using IndustryApp.Code.Models;
using IndustryApp.Code.Services;
using IndustryApp.Code.Database;
using MyProject.vCard;
using ZXing.Mobile;
using ZXing.Net.Mobile.Forms;

namespace IndustryApp.Pages
{

    public partial class Contactos : ContentPage
    {
        public Contactos()
        {
            InitializeComponent();
            //NavigationPage.SetHasBackButton(this, false);
            ToolbarItems.Add(new ToolbarItem("Nuevo", "add_contacto.png", ScanContacto));
            ToolbarItems.Add(new ToolbarItem("Exportar", "export_contacto.png", ExportarContactos));
            CargarContactos();
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
                IsAnalyzing = true
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
                        CargarContactos();

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
            if (data.GetTotalContactos() == 0)
                await DisplayAlert("IndustryApp", "Por el momento no cuentas con contactos registrados para importar", "Aceptar");
            else
            {
                var msg = await DisplayAlert("IndustryApp", "¿Deseas exportar tu lista de contactos a tu correo?", "Si", "No");
                if (!msg) return;
                var exp = new ExportarContactos();
                await exp.EnviarArchivo();
            }
        }

        public bool CargarContactos()
        {

            using (var datos = new DataAccess())
            {
                lstContactos.ItemsSource = null;
                var contactos = datos.GetContactos();
                lstContactos.ItemsSource = contactos;
                lblNoContacto.IsVisible = contactos.Count == 0;
                lstContactos.IsVisible = contactos.Count > 0;
            }
            return true;
        }

        private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            if (((ListView) sender).SelectedItem == null)
                return;
            else
            {
                var c = (Code.Models.Contactos)e.SelectedItem;
                OpcionesContacto(c);

                ((ListView)sender).SelectedItem = null;
            }
           
        }

        private async void OpcionesContacto(Code.Models.Contactos c)
        {
            var accion = await DisplayActionSheet(c.Nombre, "Cancelar", "Eliminar", "Llamar", "Enviar Correo");
            switch (accion)
            {
                case "Llamar":
                    Device.OpenUri(new Uri($"tel:{c.Telefono}"));
                    break;
                case "Enviar Correo":
                    Device.OpenUri(new Uri($"mailto:{c.Correo}"));
                    break;
                case "Eliminar":
                    using (var data = new DataAccess())
                    {
                        var eliminar =
                            await DisplayAlert("IndustryApp", "¿Deseas eliminar a este contacto?", "Si", "No");
                        if (eliminar)
                        {
                            data.DeleteContacto(c);
                            CargarContactos();
                        }
                    }
                    break;
            }
        }

        public async void AddContacto(vCardReader _contacto)
        {
            var contacto = new Code.Models.Contactos
            {
                Correo = _contacto.Emails[0].address,
                Empresa = _contacto.Org,
                Nombre = _contacto.FormattedName,
                Apellido = _contacto.Surname,
                Telefono = _contacto.Phones[0].number,
                IdUsuario = 1
            };

            var data = new DataAccess();
            if(data.GetUsuarioByCorreo(contacto.Correo) != null)
                await DisplayAlert("IndustryApp","No puedes agregarte a ti mismo como contacto", "Aceptar");
            else
            {
                var response = data.InsertContacto(contacto);
                await DisplayAlert("IndustryApp", response.Message, "Aceptar");
                CargarContactos();
            }
           
        }
    }
}
