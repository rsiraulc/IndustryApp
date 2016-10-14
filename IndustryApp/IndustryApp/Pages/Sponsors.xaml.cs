using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sponsor =  IndustryApp.Code.Models.Sponsors;
using Xamarin.Forms;

namespace IndustryApp.Pages
{
    public partial class Sponsors : ContentPage
    {
        public Sponsors()
        {
            InitializeComponent();
            var spn = new Sponsor();
            lstSponsorsPlatino.ItemsSource = spn.GetAllSponsors();
            //lstSponsorsOro.ItemsSource = spn.GetSponsorsOro();
        }

        private async void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var sponsor = e.SelectedItem;
            await Navigation.PushAsync(new SponsorDetalle((Sponsor)sponsor));
        }
    }
}
