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

            var btn = new ToolbarItem
            {
                Icon = "menu_icon.png", Priority = 0
            };
            ToolbarItems.Add(btn);
        }

        private async void btnSponsor_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sponsors());
        }

        private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var x = (MenuItem) e.SelectedItem;
            DisplayAlert("IndustryApp", x.Nombre, "OK", "Cancel");
        }
    }
}
