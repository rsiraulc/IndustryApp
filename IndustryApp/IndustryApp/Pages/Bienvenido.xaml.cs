using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using ZXing.Mobile;
using ZXing.Net.Mobile.Forms;

namespace IndustryApp.Pages
{
    public partial class Bienvenido : ContentPage
    {
        public Bienvenido()
        {
            InitializeComponent();

            CheckUsuario();
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
                DefaultOverlayTopText = "Escanea el código",
                DefaultOverlayBottomText = string.Empty,
                DefaultOverlayShowFlashButton = true
            };
            await Navigation.PushAsync(scanPage);

            scanPage.OnScanResult += (result) =>
            {
                scanPage.IsScanning = false;


                Device.BeginInvokeOnMainThread(async () =>
                {
                    await Navigation.PopAsync();
                    Application.Current.Properties["user"] = result.Text;
                    await Application.Current.SavePropertiesAsync();
                    await Navigation.PushAsync(new SeleccionEvento());

                });
            };
        }
    }
}
