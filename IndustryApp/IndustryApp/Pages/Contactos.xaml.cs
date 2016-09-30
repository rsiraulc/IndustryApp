using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;

using Xamarin.Forms;

namespace IndustryApp.Pages
{
    public class Contacto
    {
        public string Nombre { get; set; }
        public string Empresa { get; set; }
        public string Correo { get; set; }
    }

    public partial class Contactos : ContentPage
    {
        public Contactos()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
            lstContactos.ItemsSource = new List<Contacto>
            {
                new Contacto {Nombre = "Juan Castañeda", Correo = "juan@rsimexico.com", Empresa = "RSI México"},
                new Contacto {Nombre = "Roberto Arroyo", Correo = "roberto@sdpoint.com", Empresa = "SD Point"},
                new Contacto {Nombre = "Lucero Pelaez", Correo = "lucerito@medtronic.com", Empresa = "Medtronic"},
                new Contacto {Nombre = "Juan Castañeda", Correo = "juan@rsimexico.com", Empresa = "RSI México"},
                new Contacto {Nombre = "Roberto Arroyo", Correo = "roberto@sdpoint.com", Empresa = "SD Point"},
                new Contacto {Nombre = "Lucero Pelaez", Correo = "lucerito@medtronic.com", Empresa = "Medtronic"},
                new Contacto {Nombre = "Juan Castañeda", Correo = "juan@rsimexico.com", Empresa = "RSI México"},
                new Contacto {Nombre = "Roberto Arroyo", Correo = "roberto@sdpoint.com", Empresa = "SD Point"},
                new Contacto {Nombre = "Lucero Pelaez", Correo = "lucerito@medtronic.com", Empresa = "Medtronic"},
                new Contacto {Nombre = "Juan Castañeda", Correo = "juan@rsimexico.com", Empresa = "RSI México"},
                new Contacto {Nombre = "Roberto Arroyo", Correo = "roberto@sdpoint.com", Empresa = "SD Point"},
                new Contacto {Nombre = "Lucero Pelaez", Correo = "lucerito@medtronic.com", Empresa = "Medtronic"},
                new Contacto {Nombre = "Juan Castañeda", Correo = "juan@rsimexico.com", Empresa = "RSI México"},
                new Contacto {Nombre = "Roberto Arroyo", Correo = "roberto@sdpoint.com", Empresa = "SD Point"},
                new Contacto {Nombre = "Lucero Pelaez", Correo = "lucerito@medtronic.com", Empresa = "Medtronic"},
                new Contacto {Nombre = "Juan Castañeda", Correo = "juan@rsimexico.com", Empresa = "RSI México"},
                new Contacto {Nombre = "Roberto Arroyo", Correo = "roberto@sdpoint.com", Empresa = "SD Point"},
                new Contacto {Nombre = "Lucero Pelaez", Correo = "lucerito@medtronic.com", Empresa = "Medtronic"},
            };
        }
    }
}
