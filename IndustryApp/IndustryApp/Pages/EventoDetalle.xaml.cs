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
                    lblFecha.Text = "Del 23 al 25 de Noviembre del 2016";
                    lblURL.Text = "http://hermosillotransforma.com/expo";

                    //MAPA
                    coordenadas = new Position(29.1070678, -111.0230574);
                    mapa.MoveToRegion(MapSpan.FromCenterAndRadius(coordenadas, Distance.FromKilometers(1)));
                    pin = new Pin {Position = coordenadas, Label = "Parque Industrial Vie Verte", IsDraggable = false};
                    mapa.Pins.Insert(0, pin);
                    break;
                case "Mexicali Supply":
                        lblDescripcion.Text =
                            "Mexicali Supply nace con el objetivo de atraer y fortalecer redes de proveeduría a nivel local, regional e internacional que den soporte a los Sectores Industriales.Se busca acercar a las empresas tractoras de la región una oferta de productos y servicios que cumplan con los estándares de calidad que la industria requiere y puedan exponer su demanda a compañías proveedoras potenciales nacionales e internacionales.";
                    lblDescripcion2.Text =
                        "Contará con miembros de la industria de Energía Renovables, Plástica, Electrónica, Productos Médicos, Metalmecánico, Automotriz y Aeroespacial. También contará con Pabellones Especiales para los sectores Gubernamental, Desarrolladores e Instituciones Educativas.";
                    imgLogo.Source = "mse_logo.png";
                    lblFecha.Text = "Jueves 23 de Febrero del 2017";
                    lblURL.Text = "http://mexicalisupply.com/index.php/es/";

                    //MAPA
                    coordenadas = new Position(32.570379, -115.4253113);
                    mapa.MoveToRegion(MapSpan.FromCenterAndRadius(coordenadas, Distance.FromKilometers(1)));
                    pin = new Pin { Position = coordenadas, Label = "Parque Industrial El Dorado", IsDraggable = false };
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
