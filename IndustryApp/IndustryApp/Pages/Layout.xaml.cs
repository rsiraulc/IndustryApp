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
           // wvLayout.Source = "http://www.bajamak.com/index.php/es/bajamak-2013/plano-del-evento";
            CargarStands();
        }

        private void CargarStands()
        {
            var stands = new Stands();
            lvExpositores.ItemsSource = stands.GetStands();
        }
    }
}
