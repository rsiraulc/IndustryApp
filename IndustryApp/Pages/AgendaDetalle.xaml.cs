using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndustryApp.Code.Models;
using Xamarin.Forms;

namespace IndustryApp.Pages
{
    public partial class AgendaDetalle : ContentPage
    {
        public AgendaDetalle(Eventos evento)
        {
            InitializeComponent();
            lblTitulo.Text = evento.NombreEvento;
            lblFecha.Text = evento.Lugar + " " + evento.Fecha;
            lblDescripcion.Text = evento.Descripcion;
        }
    }
}
