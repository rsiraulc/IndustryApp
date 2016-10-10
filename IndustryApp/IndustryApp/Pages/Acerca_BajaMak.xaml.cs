using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace IndustryApp.Pages
{
    public partial class Acerca_BajaMak : ContentPage
    {
        public Acerca_BajaMak()
        {
            InitializeComponent();
            Content = new ScrollView() { Content = stack };
            lblDescripcion.Text = "Este 2016, BajaMak alcanza su edición número 11 y se reafirma como el foro de negocios por excelencia en Baja California y la región noroeste de México; presentando así la oportunidad de conocer en un solo día de exposición lo más destacado en productos y servicios para la industria, donde participan más de 200 empresas que buscan elevar el nivel de integración en la cadena de valor.";
            lblDescripcion2.Text = "BajaMak nace con el objetivo de atraer y fortalecer redes de proveeduría a nivel local, regional e internacional que den soporte a los Sectores Industriales de B.C. BajaMak es la oportunidad única de conocer los procesos de manufactura y necesidades de insumos de la industria maquiladora y busca un espacio en donde empresas tractoras del Estado tengan la posibilidad de exponer su demanda en base a proveeduría de insumos y servicios a compañías proveedoras potenciales nacionales e internacionales.";
            lblDescripcion3.Text = "Bajamak 11 años de fortalecer juntos la cadena de manufactura. Acompáñenos!";



        }
    }
}
