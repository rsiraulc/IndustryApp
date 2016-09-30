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
            ToolbarItems.Add(new ToolbarItem("Nuevo","add_contacto.png", () =>
            {
                ScanContacto();
            }));
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
                    await DisplayAlert("Industry App", result.Text, "OK", "Cancel");

                });
            };
        }
    }
}
