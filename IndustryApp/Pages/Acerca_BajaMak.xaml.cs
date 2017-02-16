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
            lblDescripcion.Text = "Mexicali Supply Expo nace con el objetivo de atraer y fortalecer redes de proveeduría a nivel local, regional e internacional que den soporte a los Sectores Industriales Estratégicos en Mexicali, Baja California.";
            lblDescripcion2.Text = "A través de la selección rigurosa de proveedores, se busca acercar a las empresas tractoras de la región, una oferta de productos y servicios que cumplan con los estándares de calidad que la industria requiere. En este evento también se busca un espacio en donde empresas tractoras de Baja California tengan la posibilidad de exponer su demanda en base a proveeduría de insumos y servicios a compañías proveedoras potenciales nacionales e internacionales. ";
            lblDescripcion3.Text = "Mexicali Supply Expo 2017 contará con los siguientes sectores de la industria: Energía Renovables, Plástica, Electrónica, Productos Médicos, Metalmecánico, Automotriz y Aeroespacial, conformado por empresas maquiladoras que muestran sus necesidades en materia de insumos para sus plantas instaladas en México. También contará con Pabellones Especiales para los sectores: Gubernamental, Desarrolladores e Instituciones Educativas.";
        }
    }
}
