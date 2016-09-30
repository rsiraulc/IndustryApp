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

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Menu());
        }

        async void btnScan_OnClicked(object sender, EventArgs e)
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
                    await DisplayAlert("Scaned", result.Text, "OK");
                });
            };
        }

    }
}
