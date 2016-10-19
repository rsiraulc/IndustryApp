using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocalNotifications.Plugin;
using LocalNotifications.Plugin.Abstractions;
using Xamarin.Forms;
using Evento = IndustryApp.Code.Models.Eventos;

namespace IndustryApp.Pages
{
    
    public partial class Agenda : ContentPage
    {
        public Agenda()
        {
            InitializeComponent();

            lstAgenda.ItemsSource = new List<Evento>
            {
                new Evento { NombreConferencista = "", Fecha = "Jueves 20 de Ocutbre - 10:00 A.M.", NombreEvento= "Panel: Oportunidades de los proveedores regionales en la industria de B.C.", Descripcion = "Conozca por parte de expertos en el área de compras o desarrollo de proveedores de compañías líderes de la región, los retos más comunes que se enfrenta las proveedores regionales o nacionales al buscar integrarse a la cadena de valor de la industria manufacturera. Desde errores al cotizar, hasta requerimientos de certificaciones, tiempos de entrega, calidad, precio, etc.", Lugar = "Centro de Conferencias"},
                new Evento { NombreConferencista = "", NombreEvento = "Nuevas habilidades para un nuevo entorno de la manufactura", Fecha = "Jueves 20 de Ocutbre - 11:30 A.M.", Descripcion = "En la conferencia se presentará un análisis de la evolución de la industria manufacturera en Baja California y las tendencias hacia nichos de mayor especialidad que implican incorporar a la cadena de valor nuevas tecnologías, nuevos conocimientos y nuevas maneras de organización y colaboración.", Lugar = "Centro de Conferencias"},
                new Evento { NombreConferencista = "", NombreEvento = "Panel: La industria médica en Baja California", Fecha = "Jueves 20 de Ocutbre - 12:30 A.M.", Descripcion = "Líderes del sector expondrán casos de éxito  de proveedores regionales para este sector, una radiografía de la industria médica de Baja California así como la visión desde una empresa de manufacturera, sus retos y oportunidades.", Lugar = "Centro de Conferencias"},

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

        private bool _canClose = true;

        protected override bool OnBackButtonPressed()
        {
            if (_canClose)
            {
                Salir();
            }
            return _canClose;
        }

        private async void Salir()
        {
            var answer = await DisplayAlert("IndustryApp", "¿Deseas salir de la aplicación?", "Si", "No");
            if (answer)
            {
                _canClose = false;
                if (Device.OS == TargetPlatform.Android)
                    DependencyService.Get<IAndroidMethods>().CloseApp(); ;
            }
        }

        private async void lvEventos_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var evento = (Evento) e.SelectedItem;
            await Navigation.PushAsync(new AgendaDetalle(evento));
        }
    }

}

