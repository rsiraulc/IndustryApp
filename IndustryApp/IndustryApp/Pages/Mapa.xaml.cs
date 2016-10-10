using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace IndustryApp.Pages
{
    public partial class Mapa : ContentPage
    {
        public Mapa()
        {
            InitializeComponent();
            SetLocalizacion();
        }

        private void SetLocalizacion()
        {
            var coordenadas = new Position(32.527301, -116.9659015);
            mapa.MoveToRegion(MapSpan.FromCenterAndRadius(coordenadas, Distance.FromKilometers(1)));
            var pin = new Pin {Position = coordenadas, Label = "Bajamak 2016", IsDraggable = false};
            mapa.Pins.Insert(0, pin);
        }
    }
}
