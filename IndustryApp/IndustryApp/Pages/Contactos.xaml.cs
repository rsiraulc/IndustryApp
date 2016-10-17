using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;
using Xamarin.Forms;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Android.Provider;
using IndustryApp.IndustryAppWS;
using IndustryApp.weather;
using Newtonsoft.Json;
using Org.Apache.Http.Client.Params;
using IndustryApp.Code.Models;
using IndustryApp.Code.Services;
using IndustryApp.Code.Database;
using MyProject.vCard;

namespace IndustryApp.Pages
{

    public partial class Contactos : ContentPage
    {
        public Contactos()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
            CargarContactos();
        }

        public void CargarContactos()
        {

            using (var datos = new DataAccess())
            {
                lstContactos.ItemsSource = null;
                lstContactos.ItemsSource = datos.GetContactos();

                if (datos.GetTotalContactos() == 0)
                {
                    lblNoContacto.IsVisible = true;
                    lstContactos.IsVisible = false;
                }
                else
                {
                    lblNoContacto.IsVisible = false;
                    lstContactos.IsVisible = true;
                }
            }
        }

        private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            if (((ListView) sender).SelectedItem == null)
                return;
            else
            {
                var c = (Code.Models.Contactos)e.SelectedItem;
                OpcionesContacto(c);

                ((ListView)sender).SelectedItem = null;
            }
           
        }

        private async void OpcionesContacto(Code.Models.Contactos c)
        {
            var accion = await DisplayActionSheet(c.Nombre, "Cancelar", "Eliminar", "Llamar", "Enviar Correo");
            switch (accion)
            {
                case "Llamar":
                    Device.OpenUri(new Uri($"tel:{c.Telefono}"));
                    break;
                case "Enviar Correo":
                    Device.OpenUri(new Uri($"mailto:{c.Correo}"));
                    break;
                case "Eliminar":
                    using (var data = new DataAccess())
                    {
                        var eliminar =
                            await DisplayAlert("IndustryApp", "¿Deseas eliminar a este contacto?", "Si", "No");
                        if (eliminar)
                        {
                            data.DeleteContacto(c);
                            CargarContactos();
                        }
                    }
                    break;
            }
        }

        public async void AddContacto(vCardReader _contacto)
        {
            var contacto = new Code.Models.Contactos
            {
                Correo = _contacto.Emails[0].address,
                Empresa = _contacto.Org,
                FechaRegistro = DateTime.Now,
                Nombre = _contacto.FormattedName,
                Apellido = _contacto.Surname,
                Telefono = _contacto.Phones[0].number,
                IdUsuario = 1
            };

            var data = new DataAccess();
            if(data.GetUsuarioByCorreo(contacto.Correo) != null)
                await DisplayAlert("IndustryApp","No puedes agregarte a ti mismo como contacto", "Aceptar");
            else
            {
                if (data.InsertContacto(contacto))
                    await DisplayAlert("IndustryApp", _contacto.FormattedName + " ha sido agregado a tu lista de contactos", "Aceptar");
                else
                    await DisplayAlert("IndustryApp", _contacto.FormattedName + " ya existe en tu lista de contactos", "Aceptar");

                CargarContactos();
            }
           
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
    }
}
