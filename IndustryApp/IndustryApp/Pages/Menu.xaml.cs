using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace IndustryApp.Pages
{
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
    }
}
