using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace IndustryApp.Pages
{

    public class Soluciones
    {
        public string Descripcion { get; set; }
    }

    public partial class Acerca_RSI : ContentPage
    {
        public Acerca_RSI()
        {
            InitializeComponent();
            lblDescripcion.Text = "Empresa especializada en la integración de soluciones para la automatización de procesos con presencia en Baja California, Puebla y Sonora. Contamos con todos los elementos requeridos para el proceso de impresión, identificación, rastreo y control de tus datos.";
            lblDescripcion2.Text = "Nuestras aplicaciones incluyen:";

            CargarSoluciones();
        }

        private void CargarSoluciones()
        {
            var listaSoluciones = new List<Soluciones>
            {
                new Soluciones {Descripcion = "- Identifación por radiofrecuencia (RFID)"},
                new Soluciones {Descripcion = "- Hardware y consumibles de impresión térmica"},
                new Soluciones {Descripcion = "- Desarrollo de Software"},
                new Soluciones {Descripcion = "- Hardware y consumibles para impresión a color"},
                new Soluciones {Descripcion = "- Sistemas de visión"},
                new Soluciones {Descripcion = "- Redes estructurales e inalámbricas"},
                new Soluciones {Descripcion = "- Recolección de datos (Data Collection)"},
                new Soluciones {Descripcion = "- Sistemas para manejo de almacenes (WMS)"},
                new Soluciones {Descripcion = "- Trabajos en proceso (WIP)"},
                new Soluciones {Descripcion = "- Ubicación y control de activos"},
                new Soluciones {Descripcion = "- Control de inventarios"},
            };

            lvAplicaciones.ItemsSource = listaSoluciones;
        }

        private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;
        }
    }
}
