using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace IndustryApp.Pages
{
    public partial class EventoDetalle : ContentPage
    {
        public EventoDetalle(string evento)
        {
            InitializeComponent();
            this.Title = evento;
            //lblTitulo.Text = evento;

            CargarDatosEvento(evento);
        }

        private void CargarDatosEvento(string evento)
        {
            switch (evento)
            {
                case "Hermosillo Transforma":
                    lblDescripcion.Text = "El alto potencial que representa Sonora, con su creciente industria nacional y de inversión extranjera, es sin duda la dinámica ideal para la creación del Encuentro Industrial Hermosillo Transforma.";
                    lblDescripcion2.Text = "Su cercanía con la frontera, el desarrollo del corredor industrial de manufactura avanzada Phoenix-Tucson, el interés de inversionistas en la región para impulsar sectores como el aeroespacial y su prestigio en la industria automotriz, constituyen una oportunidad para explorar y detonar nuevas áreas de desarrollo en la región. ";
                    imgLogo.Source = "logo_hermosillo.png";
                    lblFecha.Text = "Del 23 al 25 de Noviembre del 2016";
                    lblURL.Text = "http://hermosillotransforma.com/expo";
                    break;
                case "Mexicali Supply":
                    lblDescripcion.Text =
                        lblDescripcion.Text = "Mexicali Supply nace con el objetivo de atraer y fortalecer redes de proveeduría a nivel local, regional e internacional que den soporte a los Sectores Industriales.Se busca acercar a las empresas tractoras de la región una oferta de productos y servicios que cumplan con los estándares de calidad que la industria requiere, tambien donde empresas tractoras de Baja California puedan exponer su demanda a compañías proveedoras potenciales nacionales e internacionales.";
                    lblDescripcion2.Text = "Mexicali Supply contará con miembros de la industria de Energía Renovables, Plástica, Electrónica, Productos Médicos, Metalmecánico, Automotriz y Aeroespacial. También contará con Pabellones Especiales para los sectores: Gubernamental, Desarrolladores e Instituciones Educativas.";
                    imgLogo.Source = "logo_mexicali_supply.png";
                    lblFecha.Text = "Jueves 23 de Febrero del 2017";
                    lblURL.Text = "http://mexicalisupply.com/index.php/es/";
                    break;
            }
        }
    }
}
