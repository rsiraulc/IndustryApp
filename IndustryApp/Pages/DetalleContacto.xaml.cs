using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace IndustryApp.Pages
{
    public partial class DetalleContacto : ContentPage
    {
        private Code.Models.Contactos _contacto;

        public DetalleContacto(Code.Models.Contactos contacto)
        {
            InitializeComponent();
            _contacto = contacto;
            CargarContacto();
        }

        private void CargarContacto()
        {
            imgContacto.Source = "icono_contacto_sm.png";
            lblNombre.Text = _contacto.Nombre;
            lblEmpresa.Text = _contacto.Empresa;
            lblCorreo.Text = _contacto.Correo;
            lblTelefono.Text = _contacto.Telefono;
        }
    }
}
