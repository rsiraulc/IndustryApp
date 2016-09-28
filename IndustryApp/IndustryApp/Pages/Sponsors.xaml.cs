using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace IndustryApp.Pages
{
    public class Sponsor
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }

    public partial class Sponsors : ContentPage
    {
        public Sponsors()
        {
            InitializeComponent();

            lstSponsors.ItemsSource = new List<Sponsor>
            {
                new Sponsor { Nombre = "Smurfit Kappa", Descripcion = ""},
                new Sponsor { Nombre = "Medtronic", Descripcion = ""},
                new Sponsor { Nombre = "Kenmex", Descripcion = ""},
                new Sponsor { Nombre = "RSI México", Descripcion = ""},
                new Sponsor { Nombre = "Bose", Descripcion = ""},
            };
        }

        private async void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var sponsor = e.SelectedItem;
            await Navigation.PushAsync(new SponsorDetalle((Sponsor)sponsor));
        }
    }
}
