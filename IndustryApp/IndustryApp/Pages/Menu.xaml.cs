using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

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
    }
}
