using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndustryApp.Code.Models;
using Xamarin.Forms;

namespace IndustryApp.Pages
{
    public partial class Layout : ContentPage
    {
        public Layout()
        {
            InitializeComponent();
            CargarStands();
        }

        private void CargarStands()
        {
            var stands = new Stands();
            lvExpositores.ItemsSource = stands.GetStands();
        }
    }
}
