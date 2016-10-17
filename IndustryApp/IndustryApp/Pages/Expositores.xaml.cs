using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndustryApp.Code.Models;
using Xamarin.Forms;

namespace IndustryApp.Pages
{
    public partial class Expositores : ContentPage
    {
        public Expositores()
        {
            InitializeComponent();
            CargarStands();
        }

        private void CargarStands()
        {
            var stands = new Stands();
            lvExpositores.ItemsSource = stands.GetStands();
        }

        private async void lvExpositores_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var stand = (Stands) e.SelectedItem;
            await Navigation.PushAsync(new Layout(stand));
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}
