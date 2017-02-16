using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.Content;
using Xamarin.Forms;

namespace IndustryApp.Pages
{
    public partial class UberCode : ContentPage
    {
        public UberCode()
        {
            InitializeComponent();
        }

        private void btnCanjear_OnClicked(object sender, EventArgs e)
        {
            var url = "https://m.uber.com/ul/?action=applyPromo&promo=bajamak16";
            Device.OpenUri(new Uri(url));
        }
    }
}
