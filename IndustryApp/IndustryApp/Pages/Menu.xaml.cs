using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
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
                PossibleFormats = new List<ZXing.BarcodeFormat> { ZXing.BarcodeFormat.QR_CODE, ZXing.BarcodeFormat.CODE_128, ZXing.BarcodeFormat.EAN_13 },
            };

            var scanPage = new ZXingScannerPage(options)
            {
                DefaultOverlayTopText = string.Empty,
                DefaultOverlayBottomText = string.Empty,
                DefaultOverlayShowFlashButton = true
            };

            scanPage.Title = "Escanea código QR";
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
