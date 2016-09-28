using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace IndustryApp.Pages
{
    public partial class SponsorDetalle : ContentPage
    {
        public SponsorDetalle(Sponsor sponsor)
        {
            InitializeComponent();
            this.Title = sponsor.Nombre;
            lblSponsor.Text = sponsor.Nombre;
        }
    }
}
