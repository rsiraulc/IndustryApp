using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace IndustryApp.Pages
{
    public class Evento
    {
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public string Lugar { get; set; }
        public string Conferencista { get; set; }
    }

    public partial class Agenda : ContentPage
    {
        public Agenda()
        {
            InitializeComponent();

            //lstAgenda.ItemsSource = new List<Evento>
            //{
            //    new Evento { Conferencista = "Juan Lopez", Fecha = DateTime.Now, Lugar = "Sala Conferencias 2",  Nombre = "Aumentar Ventas" },
            //    new Evento { Conferencista = "Fernando Lopetegui", Fecha = DateTime.Now, Lugar = "Sala Conferencias 3",  Nombre = "¿Como ser exitoso?" },
            //};
        }
    }
}

