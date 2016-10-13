using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Javax.Security.Auth;
using Xamarin.Forms;
using ZXing.Mobile;
using ZXing.Net.Mobile.Forms;
using IndustryApp.Code.Database;
using MyProject.vCard;
using ZXing;

namespace IndustryApp.Pages
{
    public partial class Bienvenido : ContentPage
    {
        public Bienvenido()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            CheckUsuario();

            DataAccess da = new DataAccess();
        }

        private async void CheckUsuario()
        {
            if (Application.Current.Properties.ContainsKey("user"))
            {
                await Navigation.PushAsync(new SeleccionEvento());
            }
            else
            {
                btnScan.IsVisible = true;
            }
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            var options = new MobileBarcodeScanningOptions
            {
                AutoRotate = false,
                UseFrontCameraIfAvailable = false,
                TryHarder = true,
                PossibleFormats = new List<ZXing.BarcodeFormat> { ZXing.BarcodeFormat.QR_CODE, ZXing.BarcodeFormat.CODE_128, ZXing.BarcodeFormat.EAN_13 },
            };

            var scanPage = new ZXingScannerPage(options)
            {
                DefaultOverlayTopText = string.Empty,
                DefaultOverlayBottomText = string.Empty,
                DefaultOverlayShowFlashButton = true
            };
            scanPage.Title = "Escanea el código QR";
            scanPage.AutoFocus();
            await Navigation.PushAsync(scanPage);

            scanPage.OnScanResult += (result) =>
            {
                scanPage.IsScanning = false;
                if (result.Text.Contains("VCARD"))
                {
                    Device.BeginInvokeOnMainThread(async () =>
                    {
                        await Navigation.PopAsync();

                        //MANDA A LLAMAR AL PARSE DEL CODIGO QR
                        var reader = new vCardReader();
                        reader.ParseLines(result.Text);

                        await AddUsuario(reader);
                    });
                }
                else
                    DisplayAlert("IndustryApp", "Favor de leer un código valido", "Aceptar");
            };
        }

        private async Task AddUsuario(vCardReader _usuario)
        {
            var data = new DataAccess();
            var usuario = new Code.Models.Usuario
            {
                Correo = _usuario.Emails[0].address,
                Empresa = _usuario.Org,
                FechaRegistro = DateTime.Now,
                Nombre = _usuario.FormattedName,
                Telefono = _usuario.Phones[0].number,
            };

            Application.Current.Properties["user"] = usuario.Correo;
            data.InsertUsuario(usuario);
            await Application.Current.SavePropertiesAsync();
            await Navigation.PushAsync(new SeleccionEvento());
        }
    }
}
