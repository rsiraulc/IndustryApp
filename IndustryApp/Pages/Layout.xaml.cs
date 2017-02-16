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
        public Layout(Stands stand)
        {
            InitializeComponent();
            wvLayout.Source = "http://173.0.52.16/BothControl/PAGE_InicioAlterno/gAwAAOqpgq1TemRMVnlkVkJMAAA?WD_ACTION_=IMAGE&A5=-1383945750";

            Title = $"{stand.NumeroStand} - {stand.Nombre}";
        }
    }
}
