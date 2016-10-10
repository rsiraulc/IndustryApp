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

namespace IndustryApp.Pages
{

    public partial class Contactos : ContentPage
    {
        public Contactos()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
            lstContactos.IsPullToRefreshEnabled = true;

            CargarContactos();
        }

        public void CargarContactos()
        {
            ContactoService contactoService = new ContactoService();
            lstContactos.ItemsSource = null;
            lstContactos.ItemsSource = contactoService.GetListaContactos();

                //    new List<Code.Models.Contactos>
                //{
                //    new Code.Models.Contactos()
                //    {
                //        Nombre = "Rodo",
                //        Correo = "rodoc@rsimexico.com",
                //        Empresa = "RSI Mexico",
                //        FechaRegistro = DateTime.Now,
                //        Id = 1,
                //        IdUsuario = 2,
                //        Telefono = "6643050958"
                //    }
                //};
                
            lstContactos.ItemTemplate = new DataTemplate(typeof(List<Code.Models.Contactos>));

            //if (listaContactos.Count == 0)
            //{
            //    lblNoContacto.IsVisible = true;
            //    lstContactos.IsVisible = false;
            //}
            //else
            //{
            //    lblNoContacto.IsVisible = false;
            //    lstContactos.IsVisible = true;
            //}
        }

        private async void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var c = (Code.Models.Contactos) e.SelectedItem;
            OpcionesContacto(c);

            //((ListView) sender).SelectedItem = null;
        }

        private async void OpcionesContacto(Code.Models.Contactos c)
        {
            var msg =  await DisplayAlert("IndustryApp", "¿Que acción deseas realizar?", "Llamar", "Enviar Correo");
            Device.OpenUri(msg ? new Uri($"tel:{c.Telefono}") : new Uri($"mailto:{c.Correo}"));
        }

        private async void EjemploApi()
        {
            var client = new System.Net.Http.HttpClient();
            client.BaseAddress = new Uri("http://10.0.0.51:666/");
            var response = await client.GetAsync("contacto");

            var result = response.Content.ReadAsStringAsync().Result;
            var rootobject = JsonConvert.DeserializeObject<Contactos>(result);
        }

        private void EjemploWS()
        {
            var x = new WebServiceSoapClient();
            var w = new WeatherSoapClient();

            var wcf = new WCFIndustryApp.Service1Client();
            wcf.GetDataCompleted += Wcf_GetDataCompleted;
            wcf.GetDataAsync(5);
            wcf.CloseAsync();
            x.HelloWorldCompleted += X_HelloWorldCompleted;
            x.HelloWorldAsync();


        }

        private void Wcf_GetDataCompleted(object sender, WCFIndustryApp.GetDataCompletedEventArgs e)
        {
            var x = e.Result;
        }

        private void X_HelloWorldCompleted(object sender, HelloWorldCompletedEventArgs e)
        {
            try
            {
                var x = e.Result;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
