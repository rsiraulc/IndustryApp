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
                new Evento { NombreConferencista = "Panel", Fecha = "Jueves 23 de Febrero - 9:45 A.M.", NombreEvento= "Panel: Radiografía de la Industria actual en Baja California", Descripcion = "Conozca por parte de expertos en el área de compras o desarrollo de proveedores de compañías líderes de la región, los retos más comunes que se enfrenta las proveedores regionales o nacionales al buscar integrarse a la cadena de valor de la industria manufacturera", Lugar = "Area de Conferencias"},
                new Evento { NombreConferencista = "Lean Six Sigma Institute (LSSI)", NombreEvento = "Conferencia Hoshin Kanri: Planeación Estratégica Efectiva", Fecha = "Jueves 23 de Febrero - 11:45 A.M.", Descripcion = "La dirección Hoshin es una herramienta que integra consistentemente las actividades de todo el personal de la empresa de modo que puedan lograrse metas clave y reaccionar rápidamente ante cambios en el entorno. Esta disciplina parte de la idea que en toda empresa se enfrentan fuerzas que se orientan en diferentes direcciones, surgiendo entonces el desafío de reorientarlas hacia un mismo objetivo. La dirección Hoshin, bien difundida a través de las empresas japonesas a partir de los años 60 pasó a ser uno de los principales componentes de la Administración Total de la Calidad (TQM). ", Lugar = "Centro de Conferencias"},
                new Evento { NombreConferencista = "Cluster de IT Baja", NombreEvento = "Conferencia Industria 4.0: Retos y Oportunidades", Fecha = "Jueves 23 de Febrero - 12:45 A.M.", Descripcion = "Conocer la Nueva Revolución Industrial que está cambiando al mundo. Conoce a la Industria 4.0 y los retos y oportunidades que este nuevo movimiento empresarial tiene para la industria mexicana. Comparte con expertos este tema y las tendencias que están cambiando la forma de hacer negocios en el mundo. Atrévete a ser parte de los emprendedores que están dispuestos a formar parte de esta nueva revolución digital.", Lugar = "Centro de Conferencias"},

            };
        }

        private async void lvEventos_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var evento = (Evento) e.SelectedItem;
            await Navigation.PushAsync(new AgendaDetalle(evento), true);
        }
    }

}

