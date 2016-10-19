using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace IndustryApp.Pages
{
    public partial class Acerca_Contactanos : ContentPage
    {
        public Acerca_Contactanos()
        {
            InitializeComponent();
            Content = new ScrollView() { Content = stack };
            lblDescripcion3.Text = "Mex (686) 554 3233";
            lblDescripcion4.Text = "US (619) 573 9379";
            lblDescripcion5.Text = "info@bajamak.com";

            // EVENTOS TAP EN LABELS DE TELEFONO
            TapGestureRecognizer tapLbl3 = new TapGestureRecognizer();
            tapLbl3.Tapped += TapLbl3_Tapped;
            lblDescripcion3.GestureRecognizers.Add(tapLbl3);

            TapGestureRecognizer tapLbl4 = new TapGestureRecognizer();
            tapLbl4.Tapped += TapLbl4_Tapped;
            lblDescripcion4.GestureRecognizers.Add(tapLbl4);

            TapGestureRecognizer tapLbl5 = new TapGestureRecognizer();
            tapLbl5.Tapped += TapLbl5_Tapped; ;
            lblDescripcion5.GestureRecognizers.Add(tapLbl5);
        }

        private void TapLbl5_Tapped(object sender, EventArgs e)
        {
            //ENVIAR CORREO
            Device.OpenUri(new Uri("mailto:info@bajamak.com"));
        }

        private void TapLbl4_Tapped(object sender, EventArgs e)
        {
            // LLAMAR A NUMERO DE SD
            Device.OpenUri(new Uri("tel:016195739379"));
        }

        private void TapLbl3_Tapped(object sender, EventArgs e)
        {
            //LLAMADA LOCAL
            Device.OpenUri(new Uri("tel:6865543233"));
        }
    }
}
