using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocalNotifications.Plugin;
using LocalNotifications.Plugin.Abstractions;
using Xamarin.Forms;

namespace IndustryApp.Pages
{
    public class Evento
    {
        public string Nombre { get; set; }
        public string Fecha { get; set; }
        public string Lugar { get; set; }
        public string Conferencista { get; set; }
    }

    public partial class Agenda : ContentPage
    {
        public Agenda()
        {
            InitializeComponent();

            lstAgenda.ItemsSource = new List<Evento>
            {
                new Evento { Conferencista = "Juan Lopez", Fecha = "10:00 am", Lugar = "Area de Conferencias",  Nombre = "Retos de la Proveeduría para la Industria de B.C." },
            };

            EjemploNotifacion();
        }

        private void EjemploNotifacion()
        {
            var not = new LocalNotification
            {
                Text = "Que pedo",
                Title = "Que tranza",
                Id = 1,
                NotifyTime = DateTime.Now.AddSeconds(20)
            };

            var notifier = CrossLocalNotifications.CreateLocalNotifier();
            notifier.Notify(not);
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }

}

