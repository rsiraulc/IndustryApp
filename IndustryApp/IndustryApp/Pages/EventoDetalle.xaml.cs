using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace IndustryApp.Pages
{
    public partial class EventoDetalle : ContentPage
    {
        public EventoDetalle(string evento)
        {
            InitializeComponent();
            Content = new ScrollView() {Content = stack};

            this.Title = evento;
            //lblTitulo.Text = evento;

            CargarDatosEvento(evento);
        }

        private void CargarDatosEvento(string evento)
        {
            Position coordenadas;
            Pin pin;
            switch (evento)
            {
                case "Hermosillo Transforma":
                    lblDescripcion.Text =
                        "El alto potencial que representa Sonora, con su creciente industria nacional y de inversión extranjera, es sin duda la dinámica ideal para la creación del Encuentro Industrial Hermosillo Transforma.";
                    lblDescripcion2.Text =
                        "Su cercanía con la frontera, el desarrollo del corredor industrial Phoenix-Tucson, el interés de inversionistas en la región para impulsar sectores como el aeroespacial y su prestigio en la industria automotriz, constituyen una oportunidad para explorar y detonar nuevas áreas de desarrollo en la región. ";
                    imgLogo.Source = "ht_logo.png";
                    lblFecha.Text = "Noviembre del 2017";
                    lblURL.Text = "http://hermosillotransforma.com";

                    //MAPA
                    coordenadas = new Position(29.1070678, -111.0230574);
                    mapa.MoveToRegion(MapSpan.FromCenterAndRadius(coordenadas, Distance.FromKilometers(1)));
                    pin = new Pin {Position = coordenadas, Label = "Parque Industrial Vie Verte", IsDraggable = false};
                    mapa.Pins.Insert(0, pin);
                    break;
                case "BajaMak":
                        lblDescripcion.Text =
                            "BajaMak nace con el objetivo de atraer y fortalecer redes de proveeduría a nivel local, regional e internacional que den soporte a los Sectores Industriales de Baja California. ";
                    lblDescripcion2.Text =
                        "BajaMak es la oportunidad única de conocer los procesos de manufactura y necesidades de insumos de la industria maquiladora, y busca un espacio en donde empresas tractoras de Baja California tengan la posibilidad de exponer su demanda en base a proveeduría de insumos y servicios a compañías proveedoras potenciales nacionales e internacionales.";
                    imgLogo.Source = "logo_bajamak.png";
                    lblFecha.Text = "Octubre del 2017";
                    lblURL.Text = "http://www.bajamak.com";

                    //MAPA
                    coordenadas = new Position(32.5281937, -116.9670978);
                    mapa.MoveToRegion(MapSpan.FromCenterAndRadius(coordenadas, Distance.FromKilometers(1)));
                    pin = new Pin { Position = coordenadas, Label = "BajaMak", IsDraggable = false };
                    mapa.Pins.Insert(0, pin);
                    break;
            }

            TapGestureRecognizer tapGesture = new TapGestureRecognizer();
            tapGesture.Tapped += TapGesture_Tapped;
            lblURL.GestureRecognizers.Add(tapGesture);

          
        }

        private void TapGesture_Tapped(object sender, EventArgs e)
        {
            var url = lblURL.Text;
            Device.OpenUri(new Uri(url));
        }
    }
}
