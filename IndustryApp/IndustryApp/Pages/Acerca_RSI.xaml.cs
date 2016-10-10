using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace IndustryApp.Pages
{
    public partial class Acerca_RSI : ContentPage
    {
        public Acerca_RSI()
        {
            InitializeComponent();
            lblDescripcion.Text = "Empresa especializada en la integración de soluciones para la automatización de procesos con presencia en Baja California, Puebla y Sonora. Contamos con todos los elementos requeridos para el proceso de impresión, identificación, rastreo y control de tus datos.";
            lblDescripcion2.Text = "Nuestras aplicaciones incluyen:";

            string[] sAplicaciones = new string[]
            {
                "Identifación por radiofrecuencia (RFID)", "Hardware y consumibles de impresión térmica", "Desarrollo de Software",
                "Hardware y consumibles para impresión a color", "Sistemas de visión", "Redes estructurales e inalámbricas", "Recolección de datos (Data Collection)",
                "Sistemas para manejo de almacenes (WMS)", "Trabajos en proceso (WIP)", "Ubicación y control de activos", "Control de inventarios"
            };

            lvAplicaciones.ItemsSource = sAplicaciones;
        }
    }
}
